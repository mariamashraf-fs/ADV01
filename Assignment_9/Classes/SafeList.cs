using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9.Classes
{
    public class SafeList<T>
    {
        private List<T> items = new List<T>();
        public void Add(T item)
        {
            items.Add(item);
        }
        public T? GetAt(int index)
        {
            if (index < 0 || index >= items.Count)
                return default;

            return items[index];
        }
    }
}
