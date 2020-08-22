using System;
using System.Dynamic;

namespace Operator_Overloading
{
    class Program
    {
        class Box
        {
            public int Height { get;set; }
            public int Width { get; set; }
            public Box(int h,int w)
            {
                this.Height = h;
                this.Width = w;
            }
            public static Box operator + (Box b1,Box b2)
            {
                int resH = b1.Height + b2.Height;
                int resW = b1.Width + b2.Width;
                Box res = new Box(resH, resW);
                return res;
            }
        }
        static void Main(string[] args)
        {
            Box b1 = new Box(14, 3);
            Box b2 = new Box(5, 7);
            Box b3 = b1 + b2;
            Console.WriteLine("Height: {0} " , b3.Height);
            Console.WriteLine("Width: {0}" , b3.Width);
        }
    }
}
