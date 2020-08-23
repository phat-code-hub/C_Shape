using System;
using System.Collections;
using System.Collections.Generic;

namespace HashSet_app
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> hs = new HashSet<int>();
            hs.Add(5);
            hs.Add(20);
            hs.Add(100);
            hs.Add(15);
            Console.WriteLine("/nHashSet: ");
            foreach(int i in hs)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nCount:{0}", hs.Count);
            HashSet<int> hs2 = new HashSet<int>();
            hs2.Add(20);
            hs2.Add(15);
            Console.WriteLine("\n{15,20} is a subset of {5,10,15,20}: "+ hs2.IsSubsetOf(hs));
        }
    }
}
