using System;

namespace The_Spy_Life
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string message = Console.ReadLine().Trim();
            string ans = "";
            foreach (char c in message)
            {
                if (Char.IsLetter(c) || c== ' ')
                {
                    ans = c+ans;
                };
                
            };
            Console.WriteLine(ans);
        }
    }
}
