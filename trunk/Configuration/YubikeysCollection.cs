using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Yubikey.TokenSimulator.Configuration
{
	public class YubikeysCollection : ConfigurationElementCollection
	{
		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((YubikeySettings)element).Name;
		}

		protected override ConfigurationElement CreateNewElement()
		{
			YubikeySettings _settings = new YubikeySettings();
			_settings.Name = string.Format("Key{0}", Count);

			return _settings;
		}

		public YubikeySettings this[int index]
		{
			get { return (YubikeySettings)BaseGet(index); }
			set
			{
				if (BaseGet(index) != null)
				{
					BaseRemoveAt(index);
				}

				BaseAdd(index, value);
			}
		}

		public YubikeySettings this[object index]
		{
			get { return (YubikeySettings)BaseGet(index); }
			set
			{
				if (BaseGet(index) != null)
				{
					BaseRemove(index);
				}

				BaseAdd(value);
			}
		}
	}
}
