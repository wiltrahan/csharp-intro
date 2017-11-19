using System;
using System.Collections.Generic;

namespace TypeConversion
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int i = 1;
            byte b = (byte)i;
            Console.WriteLine(b);

            var number = "1234";
            int i2 = Convert.ToInt32(number);
            Console.WriteLine(i2);


            try
            {
                var number2 = "1234";
                byte b2 = Convert.ToByte(number);
                Console.WriteLine(b2);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
               
            }

            try
            {
                string str = "true";
                bool b3 = Convert.ToBoolean(str);
                Console.WriteLine(b3);
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not be converted to a bool");
                
            }
        }
    }
}