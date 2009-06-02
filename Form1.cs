using System;
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
		#region Constants
		private const int MOD_ALT = 1;
		private const int MOD_CONTROL = 2;
		private const int MOD_SHIFT = 4;
		private const int MOD_WIN = 8;
		#endregion

		#region Private Members
		private EventHandler _indexChangedHandler;
		private EventHandler _contextMenuIndexChangedHandler;

		private HotkeyHandler _enterOTPHandler;
		private HotkeyHandler.HotKeyEventHandler _enterOTPEvent_HotKeyEventHandler;
		private HotkeyHandler _incrementSessionHandler;
		private HotkeyHandler.HotKeyEventHandler _incrementSessionEvent_HotKeyEventHandler;
		private int _enterKeyDelay = 100;
		#endregion

		#region Constructor
		public Form1()
		{
			InitializeComponent();
			_indexChangedHandler = new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			_contextMenuIndexChangedHandler = new EventHandler(this.cmcboKeys_SelectedIndexChanged);
			this.cboKeys.SelectedIndexChanged += _indexChangedHandler;
			this.cmcboKeys.SelectedIndexChanged += _contextMenuIndexChangedHandler;

			_enterOTPEvent_HotKeyEventHandler = new HotkeyHandler.HotKeyEventHandler(_enterOTPHandler_OnHotKeyEvent);
			_incrementSessionEvent_HotKeyEventHandler = new HotkeyHandler.HotKeyEventHandler(_incrementSessionHandler_OnHotKeyEvent);

			PopulateKeyList();

			RegisterHotkeys();
		}
		#endregion

		#region Properties
		internal string SessionCounter
		{
			set { txtSessionCounter.Text = value; }
		}

		internal string Timestamp
		{
			set { txtTimestamp.Text = value; }
		}

		internal string UseCounter
		{
			set { txtUseCounter.Text = value; }
		}

		internal string Random
		{
			set { txtRandom.Text = value; }
		}
		#endregion

		#region Methods
		private void PopulateKeyList()
		{
			System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			YubikeysSection keysSection = (YubikeysSection)config.GetSection("tokens");
			lock (cboKeys)
			{
				this.cboKeys.SelectedIndexChanged -= _indexChangedHandler;
				this.cmcboKeys.SelectedIndexChanged -= _contextMenuIndexChangedHandler;
				YubikeySettings selectedItem = (YubikeySettings)this.cboKeys.SelectedItem;
				this.cboKeys.DataSource = null;
				foreach (YubikeySettings key in keysSection.Keys)
				{
					key.StartTime = DateTime.Now;
				}

				this.cmcboKeys.Items.AddRange(keysSection.Keys.GetAll());
				this.cboKeys.DataSource = keysSection.Keys;
				this.cboKeys.ValueMember = "Name";
				this.cboKeys.DisplayMember = "Name";
				if (selectedItem == null)
				{
					this.cboKeys.SelectedIndex = -1;
					this.cmcboKeys.SelectedIndex = -1;
				}
				else
				{
					int selectedIndex = keysSection.Keys.IndexOf(selectedItem);
					this.cboKeys.SelectedIndex = selectedIndex;
					this.cmcboKeys.SelectedIndex = selectedIndex;
				}
				this.cboKeys.SelectedIndexChanged += _indexChangedHandler;
				this.cmcboKeys.SelectedIndexChanged += _contextMenuIndexChangedHandler;
			}
			IncrementSession();
		}

		private void RegisterHotkeys()
		{
			SettingsSection settings = (SettingsSection)ConfigurationManager.GetSection("settings");
			if (settings != null)
			{
				if (_enterOTPHandler != null)
				{
					_enterOTPHandler.Dispose();
					_enterOTPHandler = null;
				}
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
							_enterKeyDelay = settings.EnterOTP.EnterKeyDelay;
							_enterOTPHandler = HotkeyHandler.Create((Keys)Enum.Parse(typeof(Keys), settings.EnterOTP.Key, true),
								(settings.EnterOTP.Alt ? MOD_ALT : 0) |
								(settings.EnterOTP.Ctrl ? MOD_CONTROL : 0) |
								(settings.EnterOTP.Win ? MOD_WIN : 0),
								_enterOTPEvent_HotKeyEventHandler);
						}
					}
					catch (Exception e)
					{
						_enterOTPHandler = null;
						MessageBox.Show("Failed registering Enter OTP hotkey.\r\n" + e.Message);
					}
				}
				if (_incrementSessionHandler != null)
				{
					_incrementSessionHandler.Dispose();
					_incrementSessionHandler = null;
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
								(settings.IncrementSession.Win ? MOD_WIN : 0),
								_incrementSessionEvent_HotKeyEventHandler);
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

		private void IncrementSession()
		{
			if (cboKeys.SelectedIndex < 0)
				return;
			System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			YubikeysSection keysSection = (YubikeysSection)config.GetSection("tokens");
			YubikeySettings key = keysSection.Keys[((YubikeySettings)cboKeys.SelectedItem).Name];
			++key.SessionCounter;
			key.UseCounter = 0;
			key.StartTime = DateTime.Now;
			byte[] buffer = new byte[3];
			RNGCryptoServiceProvider.Create().GetBytes(buffer);
			key.TimeStamp = (((int)buffer[0]) << 16) | (((int)buffer[1]) << 8) | (int)buffer[2];
			config.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection("tokens");

			int index = cboKeys.SelectedIndex;
			YubikeysCollection keys = ((YubikeysCollection)cboKeys.DataSource);
			keys[index] = key;
			cboKeys.DataSource = keys;
		}
		#endregion

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);

			SettingsSection settings = (SettingsSection)ConfigurationManager.GetSection("settings");
			if (settings.MinimizeToSysTray && settings.StartMinimized)
			{
				this.WindowState = FormWindowState.Minimized;
			}
		}

		private void Form1_Resize(object sender, System.EventArgs e)
		{
			SettingsSection settings = (SettingsSection)ConfigurationManager.GetSection("settings");
			if (this.WindowState == FormWindowState.Minimized && settings.MinimizeToSysTray)
			{
				this.Hide();
				notifyIcon1.Visible = true;
			}
		}

		void _enterOTPHandler_OnHotKeyEvent(object sender, EventArgs e)
		{
			if (cboKeys.SelectedIndex < 0)
				return;
			YubikeySettings key = ((YubikeysCollection)cboKeys.DataSource)[cboKeys.SelectedIndex];
			string otp = OTPCreator.CreateOTP(key, this);
			txtOTP.Text = otp;
			SendKeys.SendWait(otp);
			if (key.PressEnter)
			{
				SendKeys.Flush();
				Thread.Sleep(_enterKeyDelay);
				SendKeys.Send("{ENTER}");
			}
		}

		void _incrementSessionHandler_OnHotKeyEvent(object sender, EventArgs e)
		{
			IncrementSession();
		}

		private void btnCreateOTP_Click(object sender, EventArgs e)
		{
			if (cboKeys.SelectedIndex < 0)
				return;
			YubikeySettings key = ((YubikeysCollection)cboKeys.DataSource)[cboKeys.SelectedIndex];
			string otp = OTPCreator.CreateOTP(key, this);
			txtOTP.Text = otp;
			Clipboard.SetData(DataFormats.StringFormat, otp);
		}

		private void btnIncrementSession_Click(object sender, EventArgs e)
		{
			IncrementSession();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			IncrementSession();
			cmcboKeys.SelectedIndex = cboKeys.SelectedIndex;
		}

		private void manageKeysToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			YubikeysSection keysSection = (YubikeysSection)config.GetSection("tokens");
			KeyManagement window = new KeyManagement(keysSection.Keys);
			if (!this.Visible)
				window.ShowInTaskbar = true;
			window.ShowDialog();
			config.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection("tokens");
			PopulateKeyList();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			SettingsSection settings = (SettingsSection)config.GetSection("settings");
			Settings window = new Settings(settings);
			if (!this.Visible)
				window.ShowInTaskbar = true;
			DialogResult result = window.ShowDialog();
			if (result == DialogResult.OK)
			{
				config.Save(ConfigurationSaveMode.Modified);
				ConfigurationManager.RefreshSection("settings");
				if (!this.Visible && !settings.MinimizeToSysTray)
					notifyIcon1_Restore(sender, e);
				RegisterHotkeys();
			}
		}

		private void cmcboKeys_SelectedIndexChanged(object sender, EventArgs e)
		{
			cboKeys.SelectedIndex = cmcboKeys.SelectedIndex;
		}

		private void notifyIcon1_Restore(object sender, EventArgs e)
		{
			Show();
			WindowState = FormWindowState.Normal;
			notifyIcon1.Visible = false;
		}
	}
}