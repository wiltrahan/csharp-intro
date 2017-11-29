using System;
using System.Collections.Generic;

namespace TextExercises
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            //Exercise5();
        }
        
        
        // Write a program and ask the user to enter a few numbers separated by a hyphen.
        // Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
        // display a message: "Consecutive"; otherwise, display "Not Consecutive".
        public static void Exercise1()
        {
            Console.WriteLine("Enter a few numbers serperated by hyphens.");
            var input = Console.ReadLine();

            var inputSplit = input.Split('-');
            var numbers = new List<int>();
            foreach(var number in inputSplit)
            {
                numbers.Add(Convert.ToInt32(number));
            }
            numbers.Sort();

            var consecutive = true;
            for(var i = 1; i < numbers.Count; i++)
            {
                if(numbers[i] != numbers[i - 1] + 1)
                {
                    consecutive = false;
                    break;
                }

            }
            var message = consecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }
        
        // Write a program and ask the user to enter a few numbers separated by a hyphen.
        // If the user simply presses Enter, without supplying an input, exit immediately;
        // otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
        public static void Exercise2()
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

            var noDuplicates = new List<int>();
            var duplicates = false;
            foreach(var number in numberList)
            {
                if(!noDuplicates.Contains(number))
                {
                    noDuplicates.Add(number);
                }
                else
                {
                    duplicates = true;
                    break;
                }

            }
            if(duplicates)
            {
                Console.WriteLine("Duplicate");
            }
        }
        
        // Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
        // A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok";
        // otherwise, display "Invalid Time".
        // If the user doesn't provide any values, consider it as invalid time.
        public static void Exercise3()
        {
            Console.WriteLine("Enter a time, in 24-hour format. ex: 19:00");
            var input = Console.ReadLine();

            if(String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            var time = input.Split(':');
            if(time.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            var hour = Convert.ToInt32(time[0]);
            var minute = Convert.ToInt32(time[1]);
            if(hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
            {
                Console.WriteLine("Ok");
                return;
            }
            else
            {
                Console.WriteLine("Invalid Time");
                return;
            }
        }
        
        // Write a program and ask the user to enter a few words separated by a space.
        // Use the words to create a variable name with PascalCase.
        // For example, if the user types: "number of students", display "NumberOfStudents".
        // Make sure that the program is not dependent on the input.
        // So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
        public static void Exercise4()
        {
            Console.WriteLine("Enter a few words, seperated by 1 space each.");
            var input = Console.ReadLine();
            var inputSplit = input.Split(' ');

            var varName = "";
            foreach(var word in inputSplit)
            {
                var words = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                varName += words;
            }
            Console.WriteLine(varName);
        }
        
        // Write a program and ask the user to enter an English word.
        // Count the number of vowels (a, e, o, u, i) in the word.
        // So, if the user enters "inadequate", the program should display 6 on the console.
        public static void Exercise5()
        {
            Console.WriteLine("Enter a word, and I'll tell you how many vowels there are.");
            var input = Console.ReadLine().ToLower();

            var vowels = new List<char>(new char[]{'a', 'e', 'i', 'o', 'u'});
            var total = 0;
            foreach(var letter in input)
            {
                if(vowels.Contains(letter))
                {
                    total++;
                }
            }
            Console.WriteLine("There were {0} vowels in that word.", total);
        }
        
    }
}