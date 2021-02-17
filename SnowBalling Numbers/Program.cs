using System;

namespace SnowBalling_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n =Convert.ToInt32( Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] =Convert.ToInt32( Console.ReadLine());
            }
            string ans = "true";
            int sum = 0;
            for (int i=0;i<n; i++)
            {
                if (i==0)
                {
                    sum += nums[i];
                } else
                {
                    if (nums[i]<= sum)
                    {
                        ans = "false";
                        break;
                    } else
                    {
                        sum += nums[i];
                    }
                }
            }
            Console.WriteLine(ans);

        }
    }
}
