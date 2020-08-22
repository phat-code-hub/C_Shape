using System;
using System.Linq;

namespace Class
{   class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Person()
        {
            name = "Huy";
        }
        ~Person() {
            Console.WriteLine("The End of class!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name="Phat";
            Console.WriteLine(p.Name.ToUpper());
        }
    }
}
