using System;
//Draw a pyramic
namespace DrawParamic
{   
    class Program
    {
        static void drawPyramic(int n)
        {
            for (int i=1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2*i-1; k++)
                {
                    Console.Write("+");
                }
                Console.WriteLine();
            }
        }
        static int Test(out int x, int y = 4)
        {
            x = 6;
            return x * y;
        }
        static void Main(string[] args)
        {
            drawPyramic(12);
            int a;
            int z=Test(out a);
            Console.WriteLine(a + z);
        }
    }
}
