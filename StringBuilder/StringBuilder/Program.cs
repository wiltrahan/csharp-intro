using System;
using System.Collections.Generic;
using System.Text;

namespace StringBuilder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var builder = new System.Text.StringBuilder("Hello World!");
            
            /*
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            */
            //above is the same as chaining below
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);

            builder.Replace('-', '+');

            builder.Remove(0, 10);

            builder.Insert(0, new string('-', 10));
            
            Console.WriteLine(builder);

            Console.WriteLine("First char: " + builder[0]);
        }
    }
}