using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class cSharpFive
    {
        public static void Main() {

            System.Console.WriteLine("Condiotonal Statments in Csharp");

      

        }
        public void exercise1()
        {
            Console.WriteLine("Enter number between 18 to 100");
            string input = Console.ReadLine();
            long number = Convert.ToInt32(input);
            if (number >= 18 && number <= 100)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");

        }
    }
}
