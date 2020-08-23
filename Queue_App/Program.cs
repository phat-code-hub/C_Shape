using System;
using System.Collections;
using System.Collections.Generic;

namespace Queue_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(5);
            q.Enqueue(20);
            q.Enqueue(15);
            Console.WriteLine("\nQueue: ");
            foreach(int n in q)
            {
                Console.Write(n + ",");
            }
            Console.WriteLine("\nCount: " + q.Count);
            Console.WriteLine("Peek: " + q.Peek());
            Console.WriteLine("Dequeue: " + q.Dequeue());
            Console.WriteLine("\nQueue after dequeue: ");
            foreach (int n in q)
            {
                Console.Write(n + ",");
            }
            Console.WriteLine("\nCount: " + q.Count);
            Console.WriteLine("Peek: " + q.Peek());
        }
    }
}
