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
		private string _tokenID
		{
			get { return (string)base[TokenIDProperty]; }
			set { base[TokenIDProperty] = value; }
		}
		public byte[] TokenID
		{
			get { return Convert.FromBase64String(_tokenID); }
			set { _tokenID = Convert.ToBase64String(value); }
		}

		[ConfigurationProperty(SecretProperty, IsKey = false, IsRequired = true)]
		private string _secret
		{
			get { return (string)base[SecretProperty]; }
			set { base[SecretProperty] = value; }
		}
		public byte[] Secret
		{
			get { return Convert.FromBase64String(_secret); }
			set { _secret = Convert.ToBase64String(value); }
		}

		[ConfigurationProperty(SessionCounterProperty, IsKey = false, IsRequired = true)]
		public int SessionCounter
		{
			get { return (int)base[SessionCounterProperty]; }
			set { base[SessionCounterProperty] = value; }
		}

		[ConfigurationProperty(PrivateIDProperty, IsKey = false, IsRequired = true)]
		private string _privateID
		{
			get { return (string)base[PrivateIDProperty]; }
			set { base[PrivateIDProperty] = value; }
		}
		public byte[] PrivateID
		{
			get { return Convert.FromBase64String(_privateID); }
			set { _privateID = Convert.ToBase64String(value); }
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
