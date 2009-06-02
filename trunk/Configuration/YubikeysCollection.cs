using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Yubikey.TokenSimulator.Configuration
{
	public class YubikeysCollection : ConfigurationElementCollection, IList<YubikeySettings>, IList
	{
		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((YubikeySettings)element).Name;
		}

		public object[] GetAll()
		{
			return BaseGetAllKeys();
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

		#region IList<YubikeySettings> Members

		public int IndexOf(YubikeySettings item)
		{
			return BaseIndexOf(item);
		}

		public void Insert(int index, YubikeySettings item)
		{
			BaseAdd(index, item);
		}

		public void RemoveAt(int index)
		{
			BaseRemoveAt(index);
		}

		#endregion

		#region ICollection<YubikeySettings> Members

		public void Add(YubikeySettings item)
		{
			BaseAdd(item);
		}

		public void Clear()
		{
			BaseClear();
		}

		public bool Contains(YubikeySettings item)
		{
			return BaseIndexOf(item) != -1;
		}

		public void CopyTo(YubikeySettings[] array, int arrayIndex)
		{
			for (int i = 0; i < this.Count && i + arrayIndex < array.Length; ++i)
			{
				array[arrayIndex + i] = this[i];
			}
		}

		public new bool IsReadOnly
		{
			get { return false; }
		}

		public bool Remove(YubikeySettings item)
		{
			BaseRemove(item.Name);
			return BaseIsRemoved(item.Name);
		}

		#endregion

		#region IEnumerable<YubikeySettings> Members

		public new IEnumerator<YubikeySettings> GetEnumerator()
		{
			return new YubikeysCollectionEnumerator(this);
		}

		public class YubikeysCollectionEnumerator : IEnumerator<YubikeySettings>
		{
			private YubikeysCollection _collection;
			private int _index = -1;

			public YubikeysCollectionEnumerator(YubikeysCollection keys)
			{
				_collection = keys;
			}

			public bool MoveNext()
			{
				++_index;
				if (_index < _collection.Count)
				{
					return true;
				}
				else
				{
					_index = -1;
					return false;
				}
			}

			public YubikeySettings Current
			{
				get
				{
					if (_index <= -1)
					{
						throw new InvalidOperationException();
					}
					return _collection[_index];
				}
			}

			object System.Collections.IEnumerator.Current
			{
				get { return this.Current; }
			}

			public void Reset()
			{
				_index = -1;
			}

			#region IDisposable Members

			public void Dispose()
			{
			}

			#endregion
		}

		#endregion

		#region IList Members

		public int Add(object value)
		{
			if (value is YubikeySettings)
			{
				BaseAdd((YubikeySettings)value);
				return BaseIndexOf((YubikeySettings)value);
			}
			return -1;
		}

		public bool Contains(object value)
		{
			if (value is YubikeySettings)
			{
				return BaseIndexOf((YubikeySettings)value) != -1;
			}
			return false;
		}

		public int IndexOf(object value)
		{
			if (value is YubikeySettings)
			{
				return BaseIndexOf((YubikeySettings)value);
			}
			return -1;
		}

		public void Insert(int index, object value)
		{
			if (value is YubikeySettings)
			{
				BaseAdd(index, (YubikeySettings)value);
			}
		}

		public bool IsFixedSize
		{
			get { return false; }
		}

		public void Remove(object value)
		{
			if (value is YubikeySettings)
			{
				BaseRemove(((YubikeySettings)value).Name);
			}
		}

		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				if (value is YubikeySettings)
				{
					this[index] = (YubikeySettings)value;
				}
			}
		}

		#endregion
	}
}
