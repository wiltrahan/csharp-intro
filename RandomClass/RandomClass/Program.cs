using System;
using System.Collections.Generic;

namespace RandomClass
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1, 10));
            }
            */
            
            var randomChar = new Random();

            const int passwordLength = 10;

            var buffer = new char[passwordLength];

            for (int i = 0; i < passwordLength; i++)
                buffer[i] = (char) ('a' + randomChar.Next(0, 26));
            var password = new string(buffer);
            Console.WriteLine(password);
             
        }
    }
}