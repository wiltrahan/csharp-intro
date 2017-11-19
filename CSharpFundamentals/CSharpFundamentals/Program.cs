using System;
using System.Collections.Generic;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Appleseed";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
            
        }
    }
}