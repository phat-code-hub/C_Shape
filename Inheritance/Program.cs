using System;
using System.Data.Common;

namespace Inheritance
{   class Animal
    {
        public int Legs { get; set; }
        public int Age { get; set; }

    }
    class Dog:Animal
    {
        public Dog()
        {
            this.Legs = 4;
            this.Age = 25;
        }
        public void Bark()
        {
            Console.WriteLine("Woof!");
        }
    }
    class Bird:Animal
    {
        public Bird()
        {
            this.Legs = 2;
            this.Age = 48;
        }
        public void Cry()
        {
            Console.WriteLine("Meow");
        }
    }
    class Program
    {   
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Bark();
            Console.WriteLine("Cho co {0} chan.", d.Legs);
            Bird b = new Bird();
            b.Cry();
        }
    }
}
