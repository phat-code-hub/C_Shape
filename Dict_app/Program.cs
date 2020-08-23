using System;
using System.Collections;
using System.Collections.Generic;

namespace Dict_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, int> d = new Dictionary<string, int>();
            d.Add("Uno", 0);
            d.Add("One", 2);
            d.Add("Deux", 2);
            d.Remove("One");
            Console.WriteLine("\nDictionary: ");
            foreach(string k in d.Keys)
            {
                Console.WriteLine(k+" = "+d[k] );
            }
            Console.WriteLine("\nCount: " + d.Count);
        }
    }
}
