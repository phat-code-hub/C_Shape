using System;
using System.Drawing;
using System.Collections.Generic;
namespace Generic_1
{
    class Stack<T>
    {
        int index = 0;
        T[] innerArray = new T[100];
        public void Push(T item)
        {
            innerArray[index++] = item;
        }
        public T Pop()
        {
            return innerArray[--index];
        }
        public T Get(int k)
        {
            return innerArray[k];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();
            intStack.Push(3);
            intStack.Push(6);
            intStack.Push(7);
            for(int k=0;k<100;k++)
            {
               if (intStack.Get(k) > 0)
                {
                    Console.WriteLine(intStack.Get(k));
                }
            }
        }
    }
}
