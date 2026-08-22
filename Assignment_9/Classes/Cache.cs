using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9.Classes
{
    public class Cache<TKey, TValue> where TKey : notnull
    {
        private class CacheItem
        {
            public TValue Value { get; set; } = default!;
            public DateTime ExpiresAt { get; set; }
        }

        private Dictionary<TKey, CacheItem> items = new Dictionary<TKey, CacheItem>();
        public void Add(TKey key, TValue value, TimeSpan expiration)
        {
            items[key] = new CacheItem
            {
                Value = value,
                ExpiresAt = DateTime.Now + expiration
            };
        }

        public TValue? Get(TKey key)
        {
            if (!Contains(key))
                return default;

            return items[key].Value;
        }

        public bool Contains(TKey key)
        {
            if (!items.ContainsKey(key))
                return false;

            if (DateTime.Now > items[key].ExpiresAt)
            {
                items.Remove(key);
                return false;
            }

            return true;
        }

        public void Remove(TKey key)
        {
            items.Remove(key);
        }
    }
}
