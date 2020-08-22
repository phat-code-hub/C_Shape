using System;

namespace Polymorphism
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Draw Base");
        }
    }
    class Rectangle:Shape
    {
        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine("Draw Rectangle");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            //Shape s1 = new Shape();
            //s1.Draw();
            //Shape s2 = new Rectangle();
            //s2.Draw();
            Rectangle s3 = new Rectangle();
            s3.Draw();
        }
    }
}
