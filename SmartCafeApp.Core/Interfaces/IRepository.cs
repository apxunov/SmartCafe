using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCafeApp.Core.Interface
{
    public interface IRepository<T>
    {
        IEnumerable<T> Items { get; }

        void Add(T item);
        void Remove(T item);
    }
}
