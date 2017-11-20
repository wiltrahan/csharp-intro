using System;
using System.Collections.Generic;

namespace ArrayandListExercises
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            var names = new List<string>();
            while (true)
            {
                Console.Write("Type a name (or hit ENTER to quit): ");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                names.Add(input);
            }
            if (names.Count > 2)
            {
                Console.WriteLine("{0}, {1}, and {2} others like your post!", names[0], names[1], names.Count - 2);
            } 
            else if (names.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post!", names[0], names[1]);
            }
            else if (names.Count == 1)
            {
                Console.WriteLine("{0} likes your post.", names[0]);
            }
            else
            {
                Console.WriteLine();
            }
            */

            /*
            Console.WriteLine("What's your name? ");
            var name = Console.ReadLine();
            
            var array = new char[name.Length];
            for (int i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }
            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);
            */
            
            /*
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                Console.WriteLine("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've previously entered " + number);
                    continue;
                }
                numbers.Add(number);  
            }
            numbers.Sort();
            foreach (var number in numbers)
            {
                Console.WriteLine(number);                
            }
            */
            
            
            /*
            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number (or 'quit; to exit)");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;
                numbers.Add(Convert.ToInt32(input));
            }
            
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if(!uniques.Contains(number))
                    uniques.Add(number);
            }
            Console.WriteLine("Unique numbers:");
            foreach (var number in numbers)
                Console.WriteLine(number);
            */

            string[] elements;
            while (true)
            {
                Console.WriteLine("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }
                Console.WriteLine("Invalid list");
            }
            
            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));
            
            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);
                numbers.Remove(min);
            }
            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);
           
        }
    }
}