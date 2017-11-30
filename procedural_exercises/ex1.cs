using System;
using System.Collections.Generic;

// Write a program and ask the user to enter a few numbers separated by a hyphen.
// Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
// display a message: "Consecutive"; otherwise, display "Not Consecutive".
namespace proceduralExercises1
{
    internal class Program
    {
        public static bool IsConsecutive(List<int> list)
        {
            var numbers = new int[list.Count];
            list.CopyTo(numbers);
            Array.Sort(numbers);

            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                    return false;
            }

            return true;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a few numbers serperated by hyphens.");
            var input = Console.ReadLine();
            var inputSplit = input.Split('-');
            var numbers = new List<int>();
            foreach(var number in inputSplit)
            {
                numbers.Add(Convert.ToInt32(number));
            }
            var message = IsConsecutive(numbers) ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }
    }
}