using System;
using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>() {1, 2, 3, 4};
            numbers.Add(1);
            numbers.AddRange(new int[3] {5, 6, 7});

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("*****");
            
            //indexOf gives you the first index of the argument passed
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            //and this gives you last index of argument passed
            Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("Count:  " + numbers.Count);


            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);
            

        }
    }
}