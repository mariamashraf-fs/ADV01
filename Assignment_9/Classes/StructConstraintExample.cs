using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9.Classes
{
    public class StructConstraintExample<T> where T : struct
    {
        public T Value { get; set; }
    }
}
