using System;
using System.Collections.Generic;
using System.Linq;

namespace Secrete_Message
{
    class Program
    {
        static char char_Invert(char c)
        {
            char w=' ';
            if (Char.IsLetter(c))
            {
                w = (char)((int)'z' - ((int) c - (int) 'a'));
            }
            return w;
        }
        static void Main(string[] args)
        {
            string mess="";
            char[] words = Console.ReadLine().Trim().ToLower().ToCharArray();
            foreach (char letter in words) {
                mess += char_Invert(letter);
            }
            Console.WriteLine(mess);

        }
    }
}
