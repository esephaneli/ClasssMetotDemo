using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        List<KeyValuePair<TKey, TValue>> _items = new List<KeyValuePair<TKey, TValue>>();

        public void Add(TKey key, TValue value)
        {
            if (ContainsKey(key))
            {
                throw new ArgumentException("Aynı anahtara sahip bir öğe zaten eklendi");
            }

            _items.Add(new KeyValuePair<TKey, TValue>(key, value));
        }

        public bool ContainsKey(TKey key)
        {
            foreach (KeyValuePair<TKey, TValue> pair in _items)
            {
                if (EqualityComparer<TKey>.Default.Equals(pair.Key, key))
                {
                    return true;
                }
            }

            return false;
        }

        public bool Remove(TKey key)
        {
            foreach (KeyValuePair<TKey, TValue> pair in _items)
            {
                if (EqualityComparer<TKey>.Default.Equals(pair.Key, key))
                {
                    _items.Remove(pair);
                    return true;
                }
            }

            return false;
        }

        public TValue this[TKey key]
        {
            get
            {
                foreach (KeyValuePair<TKey, TValue> pair in _items)
                {
                    if (EqualityComparer<TKey>.Default.Equals(pair.Key, key))
                    {
                        return pair.Value;
                    }
                }

                throw new KeyNotFoundException();
            }
            set
            {
                for (int i = 0; i < _items.Count; i++)
                {
                    if (EqualityComparer<TKey>.Default.Equals(_items[i].Key, key))
                    {
                        _items[i] = new KeyValuePair<TKey, TValue>(key, value);
                        return;
                    }
                }

                Add(key, value);
            }
        }

        public int Count
        {
            get { return _items.Count; }
        }
    }
 
}
