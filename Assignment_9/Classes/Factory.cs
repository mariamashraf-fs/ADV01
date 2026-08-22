using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9.Classes
{
    public class Factory<T> where T : new()
    {
        public T Create()
        {
            return new T();
        }
    }
}
