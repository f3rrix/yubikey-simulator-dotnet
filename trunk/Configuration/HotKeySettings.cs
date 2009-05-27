using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Yubikey.TokenSimulator.Configuration
{
	public class HotKeySettings : ConfigurationElement
	{
		private const string EnabledProperty = "enabled";
		private const string KeyProperty = "key";
		private const string AltProperty = "alt";
		private const string CtrlProperty = "ctrl";
		private const string WinProperty = "winKey";

		public override bool IsReadOnly()
		{
			return false;
		}

		[ConfigurationProperty(EnabledProperty, DefaultValue = false)]
		public bool Enabled
		{
			get { return (bool)base[EnabledProperty]; }
			set { base[EnabledProperty] = value; }
		}

		[ConfigurationProperty(KeyProperty)]
		public string Key
		{
			get { return (string)base[KeyProperty]; }
			set { base[KeyProperty] = value; }
		}

		[ConfigurationProperty(AltProperty, DefaultValue = false)]
		public bool Alt
		{
			get { return (bool)base[AltProperty]; }
			set { base[AltProperty] = value; }
		}

		[ConfigurationProperty(CtrlProperty, DefaultValue = false)]
		public bool Ctrl
		{
			get { return (bool)base[CtrlProperty]; }
			set { base[CtrlProperty] = value; }
		}

		[ConfigurationProperty(WinProperty, DefaultValue = false)]
		public bool Win
		{
			get { return (bool)base[WinProperty]; }
			set { base[WinProperty] = value; }
		}
	}
}