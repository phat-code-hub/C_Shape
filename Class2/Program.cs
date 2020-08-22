using System;
using System.Runtime.InteropServices.ComTypes;

namespace Class2
{
    class Program
    {
        class Clients
        {
            private string[] names = new string[10];
            public string this [int index]
            {
                get
                {
                    return names[index];
                }
                set
                {
                    names[index] = value;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Clients cl = new Clients();
            cl[0] = "Phat";
            cl[1] = "Tuan";
            cl[2] = "Huy";
            Console.WriteLine(cl[2]);
        }
    }
}
