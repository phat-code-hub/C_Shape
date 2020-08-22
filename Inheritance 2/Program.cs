using System;

namespace Inheritance_2
{   
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal Created");
        }
        ~ Animal()
        {
            Console.WriteLine("Animal Deleted");
        }
    }
    //
    class Dog :Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog Created");
        }
        ~Dog()
        {
            Console.WriteLine("Dog deleted");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Animal al = new Animal();
            //Dog d = new Dog();
            Animal f = new Dog();
        }
    }
}
