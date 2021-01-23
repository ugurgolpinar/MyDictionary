using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public interface IMyDictionary<TKey, TValue>
    {
        TKey[] Keys { get; set; }
        TValue[] Values { get; set; }
        TValue this[TKey key] { get; }
        void Add(TKey key, TValue value);
        void Remove(TKey key);
        void Clear();
    }
}