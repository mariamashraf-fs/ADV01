using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9.Classes
{
    public class MultipleConstraintsExample<T> where T : Animal, IComparable<T>, new()
    {
        public T CreateDefaultAnimal()
        {
            return new T();
        }

        public bool IsBigger(T a, T b)
        {
            return a.CompareTo(b) > 0;
        }
    }
}
