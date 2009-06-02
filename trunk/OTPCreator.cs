using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Yubikey.TokenSimulator.Configuration;

namespace Yubikey.TokenSimulator
{
	public static class OTPCreator
	{
		private static readonly double TS_SEC = 0.125;

		/// <summary>
		/// Calculates the 2 byte CRC of the first 14 bytes of the input, and enters it into the 15th and 16th bytes
		/// </summary>
		/// <param name="buffer">16-byte array to be CRC'd</param>
		private static void CRC(byte[] buffer)
		{
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

		public static string CreateOTP(YubikeySettings key, Form1 form)
		{
			string tokenID = ModHex.Encode(key.TokenID);

			// Assemble key unencrypted data
			byte[] keyBytes = new byte[16];
			for (int i = 0; i < key.PrivateID.Length; ++i)
			{
				keyBytes[i] = key.PrivateID[i];
			}
			keyBytes[6] = (byte)(key.SessionCounter & 0xff);
			keyBytes[7] = (byte)((key.SessionCounter >> 8) & 0xff);
			form.SessionCounter = key.SessionCounter.ToString();
			TimeSpan diff = DateTime.Now - key.StartTime;
			int timer = (int)((((uint)(diff.TotalSeconds / TS_SEC) & 0x00FFFFFF) + key.TimeStamp) & 0x00FFFFFF);
			form.Timestamp = timer.ToString();
			keyBytes[8] = (byte)(timer & 0xff);
			keyBytes[9] = (byte)((timer >> 8) & 0xff);
			keyBytes[10] = (byte)((timer >> 16) & 0xff);
			keyBytes[11] = key.UseCounter++;
			form.UseCounter = keyBytes[11].ToString();
			byte[] buffer = new byte[2];
			RNGCryptoServiceProvider.Create().GetBytes(buffer);
			form.Random = (((int)buffer[1] << 8) + (int)buffer[0]).ToString();	
			keyBytes[12] = buffer[0];
			keyBytes[13] = buffer[1];
			CRC(keyBytes);

			using (Rijndael aes = Rijndael.Create())
			{
				aes.Padding = PaddingMode.None;
				aes.Mode = CipherMode.ECB;

				using (ICryptoTransform xform = aes.CreateEncryptor(key.Secret, new byte[16]))
				{
					byte[] plainBytes = new byte[16];
					xform.TransformBlock(keyBytes, 0, keyBytes.Length, plainBytes, 0);

					string otp = tokenID + ModHex.Encode(plainBytes);
					return otp;
				}
			}
		}

	}
}
