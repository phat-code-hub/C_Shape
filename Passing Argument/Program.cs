using System;
using System.Security.Cryptography.X509Certificates;

namespace Passing_Argument
{
    class Program
    {   
        static void Sqt(int x)
        {
            x = x * x;
            Console.WriteLine(x);
        }
        static void Sqtref(ref int x)
        {
            x = x * x;
        }
        static void getValue(out int x, out int y)
        {
            x = 5;
            y = 42;
        }
        static void Main(string[] args)
        {
            int a = 3;
            Sqt(a);
            Console.WriteLine(a);
            int b = 3;
            Sqtref(ref b);
            Console.WriteLine(b);
            int c, d;
            getValue(out c, out d);
            Console.WriteLine("{0} and {1}",c,d);
        }
    }
}
