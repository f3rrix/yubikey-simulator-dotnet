//yubikey-net

using System;
using System.Collections.Generic;
using System.Text;

namespace Yubikey.TokenSimulator
{
    public static class Hex
    {
        public static byte[] Decode(string hexString)
        {
            if (hexString == null)
            {
                throw new ArgumentNullException("hexString");
            }

            if (hexString.Length % 2 != 0)
            {
                hexString = '0' + hexString;
            }

            StringBuilder sb = new StringBuilder(hexString);
            byte[] bytes = new byte[hexString.Length / 2];
            int j = 0;

            for (int i = 0; i < hexString.Length; i += 2)
            {
				bytes[j++] = Convert.ToByte(sb.ToString(i, 2), 16);
            }

            return bytes;
        }

        public static string Encode(byte[] bytes)
        {
            if (bytes == null)
            {
                throw new ArgumentNullException("bytes");
            }

            StringBuilder sb = new StringBuilder(bytes.Length * 2);

            for (int i = 0; i < bytes.Length; i++)
            {
                byte b = bytes[i];
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }
    }
}
