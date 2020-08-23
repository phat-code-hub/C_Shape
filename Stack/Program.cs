using System;
using System.Collections.Generic;

namespace Stack_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(65);
            s.Push(72);
            s.Push(59);
            Console.WriteLine("\nStack: ");
            foreach (int n in s)
            {
                Console.Write(n + ",");
            }
            Console.WriteLine("\nCount: "+ s.Count);
            Console.WriteLine("Peek: " + s.Peek());
            Console.WriteLine("Pop: " + s.Pop());
            Console.WriteLine("\nStack after Pop: ");
            foreach (int n in s)
            {
                Console.Write(n + ",");
            }
            Console.WriteLine("\nCount: " + s.Count);
            Array tt = s.ToArray();
            foreach (int n in tt)
            {
                Console.Write(n + ",");
            };
        }
    }
}
