using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9.Classes
{
    public class InterfaceConstraintExample<T> where T : IComparable<T>
    {
        public bool IsGreater(T a, T b)
        {
            return a.CompareTo(b) > 0;
        }
    }
}
