using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9.Classes
{
    public class Animal: IComparable<Animal>
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }

        public int CompareTo(Animal? other)
        {
            return Age.CompareTo(other?.Age ?? 0);
        }
    }
}
