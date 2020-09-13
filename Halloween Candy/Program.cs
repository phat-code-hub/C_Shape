using System;

namespace Halloween_Candy
{
    class Program
    {
        static void Main(string[] args)
        {
            //get visted houses numbers
            int houses = Convert.ToInt32(Console.ReadLine());
            if (houses >= 3)
            {
                //Round the percentage of getting dollarBill
                int getBillChange = (int)(2 * 100) / houses;
                Console.WriteLine(getBillChange);
            }
            else Console.WriteLine("Visited Houses must be greater than 3!");
            
        }
    }
}
