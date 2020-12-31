using System;

namespace The_Spy_Life
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string mess = Console.ReadLine().Trim();
            string ans = "";
            foreach (char c in mess)
            {
                if (Char.IsLetter(c))
                {
                    ans = c+ans;
                };
                
            };
            Console.WriteLine(ans);
        }
    }
}
