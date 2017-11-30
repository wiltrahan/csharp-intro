// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok";
// otherwise, display "Invalid Time".
// If the user doesn't provide any values, consider it as invalid time.
using System;
using System.Collections.Generic;

namespace stringExercises3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a time, in 24-hour format. ex: 19:00");
            var input = Console.ReadLine();

            var validTimeCheck = IsValidTime(input) ? "Ok" : "Invalid Time";
            Console.WriteLine(validTimeCheck);
        }

        public static bool IsValidTime(string time)
        {
            if(String.IsNullOrWhiteSpace(time))
            {

                return false;
            }
            var timeSplit = time.Split(':');
            if(timeSplit.Length != 2)
            {

                return false;
            }
            var hour = Convert.ToInt32(timeSplit[0]);
            var minute = Convert.ToInt32(timeSplit[1]);
            if(hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
            {

                return true;
            }
            else
            {

                return false;
            }
        }
    }
}