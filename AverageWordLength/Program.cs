using System;
using System.Collections.Generic;

namespace AverageWordLength
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> lst = new List<string>();
            lst.Add("Phat");
            lst.Add("Tuan");
            int sum = 0;
            double tt = Math.Ceiling((26.0 / 5));
            foreach( string s in lst)
            {
                Console.WriteLine (s);
                sum += s.Length;
            }
            Console.WriteLine(tt);
        }
    }
}
