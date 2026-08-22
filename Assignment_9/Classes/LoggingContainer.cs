using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9.Classes
{
    public class LoggingContainer<T> : Container<T>
    {
        public override void Add(T item)
        {
            Console.WriteLine($"Adding: {item}");
            base.Add(item);
        }
    }
}
