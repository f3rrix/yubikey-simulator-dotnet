using System;
using System.Collections.Generic;
using System.Text;

namespace Yubikey.TokenSimulator
{
	public static class StringEncoding
	{
		public delegate string ParseBytes(byte[] input);

		public static ParseBytes GetEncoder(string format)
		{
			switch (format)
			{
				case "Base64":
					return Base64;
				case "Hex":
					return HexString;
				case "ModHex":
					return ModHexString;
			}
			return null;
		}

		public static string Base64(byte[] input)
		{
			return Convert.ToBase64String(input);
		}

		public static string HexString(byte[] input)
		{
			return Hex.Encode(input);
		}

		public static string ModHexString(byte[] input)
		{
			return ModHex.Encode(input);
		}
	}
}
