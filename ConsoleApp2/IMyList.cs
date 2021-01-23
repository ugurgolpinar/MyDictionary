using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public interface IMyList<T>
    {
        T[] Values { get; set; }
        T this[int index] { get; set; }
        void Add(T value);
        void Remove(T value);
        void Clear();
    }
}
