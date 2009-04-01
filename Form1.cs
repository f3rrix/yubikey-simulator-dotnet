using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Yubikey.TokenSimulator.Configuration;

namespace Yubikey.TokenSimulator
{
	public partial class Form1 : Form
	{
		private const double TS_SEC = 0.119;
		private const int MOD_ALT = 1;
		private const int MOD_CONTROL = 2;
		private const int MOD_SHIFT = 8;
		private const int MOD_WIN = 8;

		private HotkeyHandler _enterOTPHandler;
		private HotkeyHandler _incrementSessionHandler;

		public Form1()
		{
			InitializeComponent();

			System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			YubikeysSection keysSection = (YubikeysSection)config.GetSection("tokens");
			List<YubikeySettings> keys = new List<YubikeySettings>();
			foreach (YubikeySettings key in keysSection.Keys)
			{
				switch (key.KeyFormat)
				{
					case KeyFormat.Hex:
						key.Secret = Convert.ToBase64String(Hex.Decode(key.Secret));
						key.PrivateID = Convert.ToBase64String(Hex.Decode(key.PrivateID));
						key.TokenID = Convert.ToBase64String(Hex.Decode(key.TokenID));
						key.KeyFormat = KeyFormat.Base64;
						break;
					case KeyFormat.ModHex:
						key.Secret = Convert.ToBase64String(ModHex.Decode(key.Secret));
						key.PrivateID = Convert.ToBase64String(ModHex.Decode(key.PrivateID));
						key.TokenID = Convert.ToBase64String(ModHex.Decode(key.TokenID));
						key.KeyFormat = KeyFormat.Base64;
						break;
				}
				key.StartTime = DateTime.Now;
				keys.Add(key);
			}
			config.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection("tokens");

			comboBox1.DataSource = keys;
			comboBox1.ValueMember = "Name";
			comboBox1.SelectedIndex = -1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);

			DateTime start = DateTime.Now;

			RegisterHotkeys();
		}

		private void RegisterHotkeys()
		{
			HotkeySection settings = (HotkeySection)ConfigurationManager.GetSection("hotkeys");
			if (settings != null)
			{
				if (settings.EnterOTP.Enabled)
				{
					try
					{
						if (string.IsNullOrEmpty(settings.EnterOTP.Key))
						{
							MessageBox.Show("Must specify a key to register HotKey for Enter OTP");
						}
						else
						{
							_enterOTPHandler = HotkeyHandler.Create((Keys)Enum.Parse(typeof(Keys), settings.EnterOTP.Key, true),
								(settings.EnterOTP.Alt ? MOD_ALT : 0) |
								(settings.EnterOTP.Ctrl ? MOD_CONTROL : 0) |
								(settings.EnterOTP.Shift ? MOD_SHIFT : 0) |
								(settings.EnterOTP.Win ? MOD_WIN : 0));
							_enterOTPHandler.OnHotKeyEvent += new HotkeyHandler.HotKeyEventHandler(_enterOTPHandler_OnHotKeyEvent);
						}
					}
					catch (Exception e)
					{
						_enterOTPHandler = null;
						MessageBox.Show("Failed registering Enter OTP hotkey.\r\n" + e.Message);
					}
				}
				if (settings.IncrementSession.Enabled)
				{
					try
					{
						if (string.IsNullOrEmpty(settings.EnterOTP.Key))
						{
							MessageBox.Show("Must specify a key to register HotKey for Increment Session");
						}
						else
						{
							_incrementSessionHandler = HotkeyHandler.Create((Keys)Enum.Parse(typeof(Keys), settings.IncrementSession.Key, true),
								(settings.IncrementSession.Alt ? MOD_ALT : 0) |
								(settings.IncrementSession.Ctrl ? MOD_CONTROL : 0) |
								(settings.IncrementSession.Shift ? MOD_SHIFT : 0) |
								(settings.IncrementSession.Win ? MOD_WIN : 0));
							_incrementSessionHandler.OnHotKeyEvent += new HotkeyHandler.HotKeyEventHandler(_incrementSessionHandler_OnHotKeyEvent);
						}
					}
					catch (Exception e)
					{
						_incrementSessionHandler = null;
						MessageBox.Show("Failed registering Increment Session hotkey.\r\n" + e.Message);
					}
				}
			}
		}

		void _enterOTPHandler_OnHotKeyEvent(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex < 0)
				return;
			YubikeySettings key = ((List<YubikeySettings>)comboBox1.DataSource)[comboBox1.SelectedIndex];
			string otp = CreateOTP(key);
			SendKeys.SendWait(otp);
			if (key.PressEnter)
			{
				Thread.Sleep(100);
				SendKeys.SendWait("{ENTER}");
			}
		}

		void _incrementSessionHandler_OnHotKeyEvent(object sender, EventArgs e)
		{
			IncrementSession();
		}

		/// <summary>
		/// Calculates the 2 byte CRC of the first 14 bytes of the input, and enters it into the 15th and 16th bytes
		/// </summary>
		/// <param name="buffer">16-byte array to be CRC'd</param>
		private void CRC(byte[] buffer)
		{
			if (buffer.Length < 16)
			{
				MessageBox.Show("Invalid buffer, cannot calculate CRC");
				return;
			}
			ushort crc = 0x5af0;
			for (int bpos = 0; bpos < 14; ++bpos)
			{
				crc ^= buffer[bpos];
				for (int i = 0; i < 8; ++i)
				{
					int j = crc & 1;
					crc >>= 1;
					if (j != 0) crc ^= 0x8408;
				}
			}
			buffer[14] = (byte)(crc & 0xff);
			buffer[15] = (byte)((crc >> 8) & 0xff);
		}

		private string CreateOTP(YubikeySettings key)
		{
			byte[] privateID = null;
			byte[] aesKeyBytes = null;
			string tokenID = "";
			// Translate string encoded data to bytes
			switch (key.KeyFormat)
			{
				case KeyFormat.Base64:
					tokenID = ModHex.Encode(Convert.FromBase64String(key.TokenID));
					privateID = Convert.FromBase64String(key.PrivateID);
					aesKeyBytes = Convert.FromBase64String(key.Secret);
					break;
				case KeyFormat.Hex:
					tokenID = ModHex.Encode(Hex.Decode(key.TokenID));
					privateID = Hex.Decode(key.PrivateID);
					aesKeyBytes = Hex.Decode(key.Secret);
					break;
				case KeyFormat.ModHex:
					tokenID = key.TokenID;
					privateID = ModHex.Decode(key.PrivateID);
					aesKeyBytes = ModHex.Decode(key.Secret);
					break;
			}

			// Assemble key unencrypted data
			byte[] keyBytes = new byte[16];
			for (int i = 0; i < privateID.Length; ++i)
			{
				keyBytes[i] = privateID[i];
			}
			keyBytes[6] = (byte)(key.SessionCounter & 0xff);
			keyBytes[7] = (byte)((key.SessionCounter >> 8) & 0xff);
			txtSessionCounter.Text = key.SessionCounter.ToString();
			TimeSpan diff = DateTime.Now - key.StartTime;
			int timer = (int)((((uint)(diff.TotalSeconds / TS_SEC) & 0x00FFFFFF) + key.TimeStamp) & 0x00FFFFFF);
			txtTimestamp.Text = timer.ToString();
			keyBytes[8] = (byte)(timer & 0xff);
			keyBytes[9] = (byte)((timer >> 8) & 0xff);
			keyBytes[10] = (byte)((timer >> 16) & 0xff);
			keyBytes[11] = ++key.UseCounter;
			txtUseCounter.Text = key.UseCounter.ToString();
			byte[] buffer = new byte[2];
			System.Security.Cryptography.RNGCryptoServiceProvider.Create().GetBytes(buffer);
			txtRandom.Text = (((int)buffer[1] << 8) + (int)buffer[0]).ToString();
			keyBytes[12] = buffer[0];
			keyBytes[13] = buffer[1];
			CRC(keyBytes);

			using (Rijndael aes = Rijndael.Create())
			{
				aes.Padding = PaddingMode.None;
				aes.Mode = CipherMode.ECB;

				using (ICryptoTransform xform = aes.CreateEncryptor(aesKeyBytes, new byte[16]))
				{
					byte[] plainBytes = new byte[16];
					xform.TransformBlock(keyBytes, 0, keyBytes.Length, plainBytes, 0);

					string otp = tokenID + ModHex.Encode(plainBytes);
					txtOTP.Text = otp;
					return otp;
				}
			}
		}

		private void IncrementSession()
		{
			if (comboBox1.SelectedIndex < 0)
				return;
			System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			YubikeysSection keysSection = (YubikeysSection)config.GetSection("tokens");
			YubikeySettings key = keysSection.Keys[((YubikeySettings)comboBox1.SelectedItem).Name];
			++key.SessionCounter;
			key.UseCounter = 0;
			key.StartTime = DateTime.Now;
			byte[] buffer = new byte[3];
			System.Security.Cryptography.RNGCryptoServiceProvider.Create().GetBytes(buffer);
			key.TimeStamp = (((int)buffer[0]) << 16) | (((int)buffer[1]) << 8) | (int)buffer[2];
			config.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection("tokens");

			int index = comboBox1.SelectedIndex;
			List<YubikeySettings> keys = ((List<YubikeySettings>)comboBox1.DataSource);
			keys[index] = key;
			comboBox1.DataSource = keys;
		}

		private void btnCreateOTP_Click(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex < 0)
				return;
			YubikeySettings key = ((List<YubikeySettings>)comboBox1.DataSource)[comboBox1.SelectedIndex];
			string otp = CreateOTP(key);
			Clipboard.SetData(DataFormats.StringFormat, otp);
		}

		private void btnIncrementSession_Click(object sender, EventArgs e)
		{
			IncrementSession();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnIncrementSession_Click(sender, e);
		}
	}
}