using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T entity);
        T? GetById(int id);
        List<T> GetAll();
        void Remove(int id);
    }
}
