using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9.Classes
{
    public class Container<T>
    {
        private List<T> items = new List<T>();

        public virtual void Add(T item)
        {
            items.Add(item);
        }

        public T Get(int index)
        {
            return items[index];
        }
    }
}
