using Assignment_9.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9.Classes
{
    public class DogProducer : IProducer<Dog>
    {
        public Dog Produce()
        {
            return new Dog { Name = "Buddy" };
        }
    }
}
