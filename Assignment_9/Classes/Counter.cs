using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9.Classes
{
    public class Counter<T>
    {
        public static int Count { get; set; } = 0;

        public Counter()
        {
            Count++;
        }
    }
}
