using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9.Interfaces
{
    public interface IProducer<out T>
    {
        T Produce();
    }
}
