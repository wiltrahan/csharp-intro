// Write a program and ask the user to enter a few numbers separated by a hyphen.
// If the user simply presses Enter, without supplying an input, exit immediately;
// otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
using System;
using System.Collections.Generic;

namespace stringExercises2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few numbers seperated by a hyphen");
            var input = Console.ReadLine();

            if(String.IsNullOrWhiteSpace(input))
            {
                return;
            }
            var inputSplit = input.Split('-');
            var numberList = new List<int>();
            foreach(var number in inputSplit)
            {
                numberList.Add(Convert.ToInt32(number));
            }

            var message = Duplicates(numberList) ? "Duplicates" : "No Duplicates";
            Console.WriteLine(message);
        }


        public static bool Duplicates(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                    return true;
            }

            return false;
        }
    }
}