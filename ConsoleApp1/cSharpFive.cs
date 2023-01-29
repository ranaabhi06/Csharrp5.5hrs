using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class cSharpFive
    {


        public static void exercise1()
        {
            Console.WriteLine("Enter number between 18 to 100");
            string input = Console.ReadLine();
            long number = Convert.ToInt32(input);
            if (number >= 18 && number <= 100)
                Console.WriteLine( "Valid");
            else
               Console.WriteLine( "Invalid");

        }

        public static void exercise2()
        {
            Console.WriteLine("Enter First Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int max = num1 > num2 ? num1 : num2;
            Console.WriteLine("Maximum number is "+max);
        }

        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }

        public static void exercise3()
        {
            Console.WriteLine("Image Width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image Orientation is "+orientation);
        }

        public static void exercise4()
        {
            Console.WriteLine("What is the speed limit ? ");
            var speedLim = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the speed of car ? ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());
            if (carSpeed < speedLim)
                Console.WriteLine("Ok");
            else
                licenseChecker(speedLim,carSpeed);
        }
        public static void licenseChecker(int speedLim, int carSpeed)
        {
            int demeritPoints= (carSpeed-speedLim)/5;

            if (demeritPoints > 12)
                Console.WriteLine("License Suspended: ");
            else
                Console.WriteLine("Demerits Points " + demeritPoints);

            


        }

        public static void Main() {

            System.Console.WriteLine("Condiotonal Statments in Csharp");
            //cSharpFive.exercise1(); 
            //cSharpFive.exercise2();
            //cSharpFive.exercise3();
            cSharpFive.exercise4();



        }
       
    }
}
