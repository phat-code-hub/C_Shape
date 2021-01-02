﻿using System;

namespace Kaleidoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            const double TAX = 0.07;
            const double DISCOUNT = 0.1;
            const double PRICE = 5.0;
            try
            {
                int amount = Convert.ToInt32(Console.ReadLine());
                double sum = amount * PRICE;
                if (amount > 1)
                {
                    sum *= (1 - DISCOUNT);
                }
                sum *= (1 + TAX);
                Console.WriteLine(Math.Round(sum, 2));
            } 
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
                
            
        }
    }
}
