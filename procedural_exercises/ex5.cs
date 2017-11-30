// Write a program and ask the user to enter an English word.
// Count the number of vowels (a, e, o, u, i) in the word.
// So, if the user enters "inadequate", the program should display 6 on the console.

using System;
using System.Collections.Generic;

namespace stringExercises5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word, and I'll tell you how many vowels there are.");
            var input = NumberOfVowels(Console.ReadLine().ToLower());
            Console.WriteLine("There were {0} vowels in that word.", input);
        }

        public static int NumberOfVowels(string input)
        {
            var vowels = new List<char>(new char[]{'a', 'e', 'i', 'o', 'u'});
            var total = 0;
            foreach(var letter in input)
            {
                if(vowels.Contains(letter))
                {
                    total++;
                }
            }
            return total;
        }
    }
}