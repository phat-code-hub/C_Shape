using System;
using System.Collections.Generic;
using System.Threading;

namespace List_T
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            lst.Add(52);
            lst.Add(4);
            Console.WriteLine("\nList:");
            for (int n=0; n < lst.Count; n++)
            {
                Console.WriteLine(lst[n]);
            }
            lst.Sort();
            Console.WriteLine("\nList after sort:");
            for (int n = 0; n < lst.Count; n++)
            {
                Console.WriteLine(lst[n]);
            }

        }
    }
}
