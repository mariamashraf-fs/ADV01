using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9.Interfaces
{
    public interface IPrinter<in T>
    {
        void Print(T item);
    }
}
