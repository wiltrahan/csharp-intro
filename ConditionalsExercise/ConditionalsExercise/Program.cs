using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConditionalsExercise
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
        }

        public void Ex1()
        {
            Console.WriteLine("Enter a number between 1 & 10");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Good Work!");
            }
            else
            {
                Console.WriteLine("Try again!");
            }
        }

        public void Ex2()
        {
            Console.WriteLine("Enter a number: ");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number");
            var num2 = Convert.ToInt32(Console.ReadLine());
            
            var max = (num1 > num2) ? num1 : num2;
            Console.WriteLine("Max is " + max);
        }

        public void Ex3()
        {
            Console.WriteLine("Width: ");
            var width = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var type = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is " + type);
        }

        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }

        public void Ex4()
        {
            Console.WriteLine("Speed limit? ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the speed of this car? ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("You are ok!");
            }
            else
            {
                const int point = 5;
                var demeritPoints = (carSpeed - speedLimit) / point;
                if (demeritPoints > 12)
                {
                    Console.WriteLine("Suspended :(");
                }
                else
                {
                    Console.WriteLine("Demerit points: ", demeritPoints);
                }
            }
        }
    }
}