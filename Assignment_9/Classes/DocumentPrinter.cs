using Assignment_9.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9.Classes
{
    public class DocumentPrinter : IPrinter<object>
    {
        public void Print(object item)
        {
            Console.WriteLine($"Printing: {item}");
        }
    }
}
