// Write a program and ask the user to enter a few words separated by a space.
// Use the words to create a variable name with PascalCase.
// For example, if the user types: "number of students", display "NumberOfStudents".
// Make sure that the program is not dependent on the input.
// So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

using System;
using System.Collections.Generic;

namespace stringExercises4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few words, seperated by 1 space each.");
            var input = PascalCase(Console.ReadLine());
            Console.WriteLine(input);
        }

        public static string PascalCase(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                return "";
            }

            var inputSplit = input.Split(' ');
            var varName = "";
            foreach(var word in inputSplit)
            {
                var words = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                    varName += words;

            }
            return varName;
        }
    }
}