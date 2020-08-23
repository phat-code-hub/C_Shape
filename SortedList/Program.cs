using System;
using System.Collections.Generic;
namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<String, int> sl = new SortedList<string, int>();
            sl.Add("Solo", 59);
            sl.Add("A", 92);
            sl.Add("Learn", 72);
            sl.Remove("A");
            Console.WriteLine("\nSortedList: ");
            foreach(String st in sl.Keys)
            {
                Console.WriteLine(sl[st]);
            }
            Console.WriteLine("Count: " + sl.Count);
        }
    }
}
