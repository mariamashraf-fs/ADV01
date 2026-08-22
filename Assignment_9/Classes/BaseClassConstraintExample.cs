using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9.Classes
{
    public class BaseClassConstraintExample<T> where T : Animal
    {
        public void Speak(T animal)
        {
            animal.MakeSound();
        }
    }
}
