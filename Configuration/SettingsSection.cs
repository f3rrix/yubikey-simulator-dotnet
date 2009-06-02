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
		private const string MinimizeToSysTrayProperty = "minimizeToSysTray";
		private const string StartMinimizedProperty = "startMinimized";

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

		[ConfigurationProperty(MinimizeToSysTrayProperty)]
		public bool MinimizeToSysTray
		{
			get { return (bool)base[MinimizeToSysTrayProperty]; }
			set { base[MinimizeToSysTrayProperty] = value; }
		}

		[ConfigurationProperty(StartMinimizedProperty)]
		public bool StartMinimized
		{
			get { return (bool)base[StartMinimizedProperty]; }
			set { base[StartMinimizedProperty] = value; }
		}
	}
}
