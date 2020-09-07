using System;
using System.Text;

namespace Prime_String1
{
    class Program
    {
        static string word;
        static string ans;
        static String compareString()
        {
            
            return "prime";
        }
        static void Main(string[] args)
        {
            word = Console.ReadLine().Trim().ToLower();
            if (word.Length>0) {
                ans=compareString();
            }
        }
    }
}
