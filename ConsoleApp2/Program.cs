using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("a");
            myList.Add("b");
            myList.Add("c");
            GetValues(myList);
            myList[2] = "d";
            GetValues(myList);
            myList.Remove("d");
            GetValues(myList);
            myList.Clear();
            GetValues(myList);

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Adana");
            myDictionary.Add(6, "Ankaraa");
            myDictionary.Add(32, "Isparta");
            myDictionary.Add(34, "İstanbul");
            GetValues(myDictionary);
            myDictionary.Remove(1);
            GetValues(myDictionary);
            myDictionary[6] = "Ankara";
            GetValues(myDictionary);
            myDictionary.Clear();
            GetValues(myDictionary);
        }

        public static void GetValues(MyDictionary<int, string> myDictionary)
        {
            for (int i = 0; i < myDictionary.Keys.Length; i++)
            {
                Console.WriteLine(myDictionary.Values[i]);
            }

            if (myDictionary.Values.Length != 0)
                Console.WriteLine("------------------");
        }

        public static void GetValues(MyList<string> myList)
        {
            for (int i = 0; i < myList.Values.Length; i++)
            {
                Console.WriteLine(myList.Values[i]);
            }

            if (myList.Values.Length != 0)
                Console.WriteLine("------------------");
        }
    }
}
