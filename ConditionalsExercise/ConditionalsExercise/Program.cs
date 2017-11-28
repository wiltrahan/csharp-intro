using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConditionalsExercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
        }
        
        //Write a program and ask the user to enter a number. 
        //The number should be between 1 to 10. 
        //If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
        
        private static void Exercise1()
        {
            Console.WriteLine("Enter a number between 1 & 10");
            var input = Convert.ToInt32(Console.ReadLine());
            if (input >= 1 && input <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        
        //Write a program which takes two numbers from the console and displays the maximum of the two.
        
        public static void Exercise2()
        {
            Console.WriteLine("Enter a number: ");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number");
            var num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("{0} was the max", num1);
            }
            else
            {
                Console.WriteLine("{0} was the max", num2);
            }
        }
        
        //Write a program and ask the user to enter the width and height of an image. 
        //Then tell if the image is landscape or portrait.

        public static void Exercise3()
        {
            Console.WriteLine("Width: ");
            var width = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("Image is landscape");
            }
            else
            {
                Console.WriteLine("Image is portrait");
            }
        }

        //Write a program that asks the user to enter the speed limit. 
        //Once set, the program asks for the speed of a car. 
        //If the user enters a value less than the speed limit, program should display Ok on the console. 
        //If the value is above the speed limit, the program should calculate the number of demerit points. 
        //For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
        //If the number of demerit points is above 12, the program should display License Suspended.
      
        public static void Exercise4()
        {
            Console.WriteLine("Speed limit? ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the speed of the car? ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("OK!");
            }
            else
            {
                var point = 5;
                var demeritPoints = (carSpeed - speedLimit) / point;
                if (demeritPoints > 12)
                {
                    Console.WriteLine("You have {0} demerit points.  Your license is suspended.", demeritPoints);
                }
                else
                {
                    Console.WriteLine("Demerit points: ", demeritPoints);
                }
            }
        }
       
    }
}