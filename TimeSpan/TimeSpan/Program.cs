using System;
using System.Collections.Generic;

namespace TimeSpan
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //creating
            var timeSpan = new System.TimeSpan(1, 2, 3);
            var timeSpan1 = new System.TimeSpan(1, 0, 0);
            System.TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);
            
            //properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total minutes: " + timeSpan.TotalMinutes);
            
            
            //Add & Subtract
            Console.WriteLine("Add Example: " + timeSpan.Add(System.TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(System.TimeSpan.FromMinutes(2)));
            
            //ToString
            Console.WriteLine("ToString " + timeSpan.ToString());
            
            //Parse
            Console.WriteLine("Parse: " + System.TimeSpan.Parse("01:02:03"));
        }
    }
}