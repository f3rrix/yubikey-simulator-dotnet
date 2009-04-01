using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Yubikey.TokenSimulator.Configuration
{
	public class YubikeysSection : ConfigurationSection
	{
		private const string keysProperty = "keys";

		[ConfigurationProperty(keysProperty, IsDefaultCollection=true)]
		public YubikeysCollection Keys
		{
			get { return (YubikeysCollection)base[keysProperty]; }
			set { base[keysProperty] = value; }
		}
	}
}
