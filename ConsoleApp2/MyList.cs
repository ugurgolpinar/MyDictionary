using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class MyList<T> : IMyList<T>
    {
        public MyList()
        {
            Values = new T[0];
        }
        public T[] Values { get; set; }
        public T this[int index]
        {
            get => Values[index];
            set => Values[index] = value;
        }

        public void Add(T value)
        {
            T[] TempValues = Values;
            Values = new T[Values.Length + 1];

            for (int i = 0; i < TempValues.Length; i++)
            {
                Values[i] = TempValues[i];
            }
            Values[Values.Length - 1] = value;
        }
        public void Clear()
        {
            Values = new T[0];
        }
        public void Remove(T value)
        {
            T[] TempValues = new T[Values.Length - 1];
            bool isMatched = false;

            for (int i = 0; i < Values.Length; i++)
            {
                if (Values[i].Equals(value))
                {
                    isMatched = true;
                    if (i >= 0 && i < Values.Length - 1)
                        TempValues[i] = Values[i + 1];
                    else
                        break;
                }
                else if (i == Values.Length - 1)
                    break;
                else if (isMatched)
                    TempValues[i] = Values[i + 1];
                else
                    TempValues[i] = Values[i];
            }
            Values = TempValues;
        }
    }
}
