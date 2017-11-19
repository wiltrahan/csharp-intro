using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;

namespace Arrays
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            
            
            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]); 
            Console.WriteLine(flags[1]);        
            Console.WriteLine(flags[2]);

            var names = new string[3] {"Jim", "Bob", "Frank"};

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}