using System;
using System.Collections.Generic;

namespace ifElseSwitch
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            int hour = 12;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("Its morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Its afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }

            bool isGoldCustomer = true;

            float price;
            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            }

            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);
            */
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("Its autumn!");
                    break;
                    
                case Season.Summer:
                    Console.WriteLine("Its Summer! (i wish)");
                    break;
                    
                default:
                    Console.WriteLine("I don't know what season it is.");
                    break;
            }
        }
    }
}