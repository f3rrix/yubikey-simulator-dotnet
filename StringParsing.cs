using System;
using System.Collections.Generic;
using System.Text;

namespace Yubikey.TokenSimulator
{
	public static class StringParsing
	{
		public delegate byte[] ParseString(string input);

		public static ParseString GetParser(string format)
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

		public static byte[] Base64(string input)
		{
			return Convert.FromBase64String(input);
		}

		public static byte[] HexString(string input)
		{
			return Hex.Decode(input);
		}

		public static byte[] ModHexString(string input)
		{
			return ModHex.Decode(input);
		}
	}
}
