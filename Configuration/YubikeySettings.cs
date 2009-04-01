using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Yubikey.TokenSimulator.Configuration
{
	public class YubikeySettings : ConfigurationElement
	{
		private const string NameProperty = "name";
		private const string SecretProperty = "secret";
		private const string SessionCounterProperty = "sessionCounter";
		private const string TokenIDProperty = "tokenID";
		private const string PrivateIDProperty = "privateID";
		private const string KeyFormatProperty = "keyFormat";
		private const string PressEnterProperty = "pressEnter";

		public override bool IsReadOnly()
		{
			return false;
		}

		[ConfigurationProperty(NameProperty, IsKey = true, IsRequired = true)]
		public string Name
		{
			get { return (string)base[NameProperty]; }
			set { base[NameProperty] = value; }
		}

		[ConfigurationProperty(TokenIDProperty, IsKey = false, IsRequired = true)]
		public string TokenID
		{
			get { return (string)base[TokenIDProperty]; }
			set { base[TokenIDProperty] = value; }
		}

		[ConfigurationProperty(SecretProperty, IsKey = false, IsRequired = true)]
		public string Secret
		{
			get { return (string)base[SecretProperty]; }
			set { base[SecretProperty] = value; }
		}

		[ConfigurationProperty(SessionCounterProperty, IsKey = false, IsRequired = true)]
		public int SessionCounter
		{
			get { return (int)base[SessionCounterProperty]; }
			set { base[SessionCounterProperty] = value; }
		}

		[ConfigurationProperty(PrivateIDProperty, IsKey = false, IsRequired = true)]
		public string PrivateID
		{
			get { return (string)base[PrivateIDProperty]; }
			set { base[PrivateIDProperty] = value; }
		}

		[ConfigurationProperty(KeyFormatProperty, IsKey = false, IsRequired = false, DefaultValue = KeyFormat.Base64)]
		public KeyFormat KeyFormat
		{
			get { return (KeyFormat)base[KeyFormatProperty]; }
			set { base[KeyFormatProperty] = value; }
		}

		[ConfigurationProperty(PressEnterProperty, IsRequired = false, DefaultValue = true)]
		public bool PressEnter
		{
			get { return (bool)base[PressEnterProperty]; }
			set { base[PressEnterProperty] = value; }
		}

		private byte _useCounter;
		public byte UseCounter
		{
			get { return _useCounter; }
			set { _useCounter = value; }
		}

		private DateTime _startTime;
		public DateTime StartTime
		{
			get { return _startTime; }
			set { _startTime = value; }
		}

		private int _timestamp;
		public int TimeStamp
		{
			get { return _timestamp; }
			set { _timestamp = value; }
		}
	}
}
