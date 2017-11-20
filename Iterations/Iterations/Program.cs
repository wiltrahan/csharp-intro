using System;
using System.Collections.Generic;

namespace Iterations
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (int i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            var name = "John Smith";
            /*
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
           

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
            */

            var numbers = new int[] {1, 2, 3, 4};
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}