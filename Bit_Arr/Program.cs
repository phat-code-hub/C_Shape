using System;
using System.Collections;
namespace Bit_Arr
{
    
    class Program
    {
        static void PrintBarr(String name, BitArray ba)
        {
            Console.WriteLine(name + " : ");
            for (int x =0; x < ba.Count; x++)
            {
                Console.WriteLine(ba.Get(x));
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            BitArray b1 = new BitArray(4);
            BitArray b2 = new BitArray(4);
            b1.SetAll(true);
            b2.SetAll(false);
            b1.Set(2, false);
            b2.Set(3, true);
            PrintBarr("b1 AND b2", b1.And(b2));
            PrintBarr("b1 OR b2", b1.Or(b2));
            PrintBarr("b1 XOR b2", b1.Xor(b2));
        }
    }
}
