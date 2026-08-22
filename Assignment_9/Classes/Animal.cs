using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9.Classes
{
    public class Animal
    {
        public string Name { get; set; } = string.Empty;
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }
    }
}
