using System;

namespace Conditional_and_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("x= ");
                String st = Console.ReadLine();
                if (st=="exit") {
                    break;
                }
                int x = Convert.ToInt32(st);
                Console.Write("y= ");
                int y = Convert.ToInt32(Console.ReadLine());
                int sum = x + y;
                Console.WriteLine("Sum is {0}", sum);
                //Console.WriteLine("Sum is " + sum);
            } while (true);
        }
    }
}
