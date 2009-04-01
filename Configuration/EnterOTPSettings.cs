using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Yubikey.TokenSimulator.Configuration
{
	public class EnterOTPSettings : HotKeySettings
	{
		private const string EnterKeyDelayProperty = "enterKeyDelay";

		[ConfigurationProperty(EnterKeyDelayProperty, DefaultValue = 100)]
		public int EnterKeyDelay
		{
			get { return (int)base[EnterKeyDelayProperty]; }
			set { base[EnterKeyDelayProperty] = value; }
		}
	}
}
