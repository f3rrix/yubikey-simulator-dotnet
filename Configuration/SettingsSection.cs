using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Yubikey.TokenSimulator.Configuration
{
	public class SettingsSection : ConfigurationSection
	{
		private const string EnterOTPProperty = "enterOTP";
		private const string IncrementSessionProperty = "incrementSession";

		[ConfigurationProperty(EnterOTPProperty)]
		public EnterOTPSettings EnterOTP
		{
			get { return (EnterOTPSettings)base[EnterOTPProperty]; }
			set { base[EnterOTPProperty] = value; }
		}

		[ConfigurationProperty(IncrementSessionProperty)]
		public HotKeySettings IncrementSession
		{
			get { return (HotKeySettings)base[IncrementSessionProperty]; }
			set { base[IncrementSessionProperty] = value; }
		}
	}
}
