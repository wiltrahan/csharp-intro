using System;
using System.Collections.Generic;
using System.Globalization;

namespace LoopsExercise
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

        //Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
        //Display the count on the console.
        public static void Exercise1()
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine("{0} numbers are divisble by 3", count);
        }
        
        //Write a program and continuously ask the user to enter a number or "ok" to exit. 
        //Calculate the sum of all the previously entered numbers and display it on the console.
        public static void Exercise2()
        {
            var total = 0;
            while (true)
            {
                Console.WriteLine("Enter a number, or 'ok' to exit: ");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                    break;
                total = total + Convert.ToInt32(input);
            }
            
            Console.WriteLine("Total is: " + total);
        }
        
        //Write a program and ask the user to enter a number. 
        //Compute the factorial of the number and print it on the console. 
        //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
        public static void Exercise3()
        {
            Console.WriteLine("Give me a number... ");
            var input = Convert.ToInt32(Console.ReadLine());

            var factor = 1;
            for (var i = 1; i <= input; i++)
            {
                factor = factor * i;
            }
            Console.WriteLine("{0}! = {1}", input, factor);  
        }

        //Write a program that picks a random number between 1 and 10. 
        //Give the user 4 chances to guess the number. 
        //If the user guesses the number, display “You won"; otherwise, display “You lost".
        public static void Exercise4()
        {
            
            var randomNumber = new Random().Next(1, 10);

            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Give me a number between 1 & 10");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == randomNumber)
                {
                    Console.WriteLine("You got it!");
                    return;
                }
            }
            Console.WriteLine("Sorry, you only get 4 tries...NEXT!");
        }
        
        //Write a program and ask the user to enter a series of numbers separated by comma. 
        //Find the maximum of the numbers and display it on the console. 
        //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

        public static void Exercise5()
        {
            Console.WriteLine("Enter a few numbers seperated by commas: ");
            var input = Console.ReadLine();
            //split line into array
            var numbers = input.Split(',');
            //start with the first 
            var max = Convert.ToInt32(numbers[0]);

            foreach (var number in numbers)
            {
                var converted = Convert.ToInt32(number);
                if (converted > max)
                {
                    max = converted;
                }     
            }
            Console.WriteLine("Biggest number is " + max);
        }
    }
}