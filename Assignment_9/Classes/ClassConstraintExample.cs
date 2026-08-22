using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9.Classes
{
    public class ClassConstraintExample<T> where T : class
    {
        public T? Value { get; set; }
    }
}
