using System;
using System.Collections.Generic;

namespace ArrayandListExercises
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
        // If no one likes your post, it doesn't display anything.
        // If only one person likes your post, it displays: [Friend's Name] likes your post.
        // If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
        // If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People]
        // others like your post.
        // Write a program and continuously ask the user to enter different names, until the user presses Enter
        // (without supplying a name).
        // Depending on the number of names provided, display a message based on the above pattern.
        private static void Exercise1()
        {
            var names = new List<string>();

            while(true)
            {
                Console.WriteLine("Give me a name, or press 'enter' to exit");
                var inputName = Console.ReadLine();
                if(String.IsNullOrWhiteSpace(inputName))
                    break;
                names.Add(inputName);
            }
            if(names.Count > 2)
            {
                Console.WriteLine("{0}, {1}, and {2} others like your post!", names[0], names[1], names.Count - 2);
            }
            else if(names.Count == 2)
            {
                Console.WriteLine("{0}, {1} like your post!", names[0], names[1]);
            }
            else if(names.Count == 1)
            {
                Console.WriteLine("{0} likes your post!", names[0]);
            }
            else
            {
                Console.WriteLine("No likes yet :(");
            }
        }

        //Write a program and ask the user to enter their name.
        //Use an array to reverse the name and then store the result in a new string.
        //Display the reversed name on the console.
        private static void Exercise2()
        {
            Console.WriteLine("What is your name? ");
            var input = Console.ReadLine();

            var array = new char[input.Length];
            for (int i = input.Length; i > 0; i--)
            {
                array[input.Length - i] = input[i - 1];
            }
            var reversed = new string(array);
            Console.WriteLine("Here it is...IN REVERSE! " + reversed);
        }
        
        // Write a program and ask the user to enter 5 numbers.
        // If a number has been previously entered, display an error message and ask the user to re-try.
        // Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
        private static void Exercise3()
        {
            var numbers = new List<int>();
            while(numbers.Count < 5)
            {
                Console.WriteLine("Give me a number ");
                var number = Convert.ToInt32(Console.ReadLine());
                if(numbers.Contains(number))
                {
                    Console.WriteLine("You already entered {0}, please try again ", number);
                    continue;
                }
                numbers.Add(number);
            }
            numbers.Sort();

            Console.WriteLine("***sorted***");
            for(var i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        
        // Write a program and ask the user to continuously enter a number or type "Quit" to exit.
        // The list of numbers may include duplicates. Display the unique numbers that the user has entered.
        private static void Exercise4()
        {
            var numbers = new List<int>();
            while(true)
            {
                Console.WriteLine("Give me a number, or type 'quit' to exit");
                var input = Console.ReadLine();
                if(input.ToLower() == "quit")
                    break;
                numbers.Add(Convert.ToInt32(input));
            }
            var uniqueNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if(!uniqueNumbers.Contains(number))
                    uniqueNumbers.Add(number);
            }
            Console.WriteLine("***unique numbers***");
            foreach (var number in uniqueNumbers)
                Console.WriteLine(number);
        }
        
        // Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
        // If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
        // otherwise, display the 3 smallest numbers in the list.
        private static void Exercise5()
        {
            string[] inputArray;

            while(true)
            {
                Console.WriteLine("Enter a list of at least 5 comma seperated numbers");
                var input = Console.ReadLine();

                
                if(!String.IsNullOrWhiteSpace(input))
                {
                    inputArray = input.Split(',');
                    if(inputArray.Length >= 5)
                        break;

                }
                Console.WriteLine("Invalid List, please try again.");
            }

            var numbers = new List<int>();
            foreach (var number in inputArray)
                numbers.Add(Convert.ToInt32(number));

            var minList = new List<int>();
            while (minList.Count < 3)
            {
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                minList.Add(min);
                numbers.Remove(min);
            }
            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in minList)
                Console.WriteLine(number);
        }     
    }
     
}