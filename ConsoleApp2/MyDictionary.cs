using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class MyDictionary<TKey, TValue> : IMyDictionary<TKey, TValue>
    {
        public MyDictionary()
        {
            Keys = new TKey[0];
            Values = new TValue[0];
        }
        public TKey[] Keys { get; set; }
        public TValue[] Values { get; set; }
        public TValue this[TKey key]
        {
            get
            {
                int index = 0;
                for (int i = 0; i < Keys.Length; i++)
                {
                    if (Keys[i].Equals(key))
                    {
                        index = i;
                        break;
                    }
                }

                return Values[index];
            }
            set
            {
                for (int i = 0; i < Keys.Length; i++)
                {
                    if (Keys[i].Equals(key))
                    {
                        Values[i] = value;
                        break;
                    }
                }
            }
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] TempKeys = Keys;
            TValue[] TempValues = Values;
            Keys = new TKey[Keys.Length + 1];
            Values = new TValue[Values.Length + 1];

            for (int i = 0; i < TempKeys.Length; i++)
            {
                Keys[i] = TempKeys[i];
            }
            Keys[Keys.Length - 1] = key;

            for (int i = 0; i < TempValues.Length; i++)
            {
                Values[i] = TempValues[i];
            }
            Values[Values.Length - 1] = value;
        }
        public void Clear()
        {
            Keys = new TKey[0];
            Values = new TValue[0];
        }
        public void Remove(TKey key)
        {
            TKey[] TempKeys = new TKey[Keys.Length - 1];
            TValue[] TempValues = new TValue[Keys.Length - 1];
            bool isMatched = false;

            for (int i = 0; i < Keys.Length; i++)
            {
                if (Keys[i].Equals(key))
                {
                    isMatched = true;
                    if (i >= 0 && i < Keys.Length - 1)
                    {
                        TempKeys[i] = Keys[i + 1];
                        TempValues[i] = Values[i + 1];
                    }
                    else
                        break;
                }
                else if (i == Keys.Length - 1)
                    break;
                else if (isMatched)
                {
                    TempKeys[i] = Keys[i + 1];
                    TempValues[i] = Values[i + 1];
                }
                else
                {
                    TempKeys[i] = Keys[i];
                    TempValues[i] = Values[i];
                }
            }
            Keys = TempKeys;
            Values = TempValues;
        }
    }
}
