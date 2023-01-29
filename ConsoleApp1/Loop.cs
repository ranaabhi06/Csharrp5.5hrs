using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Loop
    {
        public static void Main2()
        {
            System.Console.WriteLine("Loops and iterations::");
            //Loop.exercise1();
            //Loop.exercise2();
            //Loop.exercise3();
            //Loop.exercise4();
            Loop.exercise5();
        }
        public static void exercise1()
        {
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100 .",count);
        }

        public static void exercise2()
        {
            var sum = 0;
                while (true) {
                Console.WriteLine("Enter a number or OK to exit::");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                    break;
                sum += Convert.ToInt32(input);
                 }
            Console.WriteLine("Sum of all numbers is :" + sum);
        }


        public static void exercise3()
        {
            Console.WriteLine("Enter a number::");
            var number = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;
            for (int i = 1; i <= number; i++)
                factorial *= i;

            Console.WriteLine("{0}!={1}", number, factorial);
        }

        public static void exercise4()
        {
            int num = new Random().Next(1, 10);
            Console.WriteLine("Secret number is " + num);

            for(var i = 1; i < 5; i++)
            {
                Console.WriteLine("Guess the number: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if(guess==num)
                {
                    Console.WriteLine("Great guess!!");
                    return;
                }
            }
            Console.WriteLine("Sorry! You Lost.");
        }



        public static void exercise5()
        {
            Console.Write("Enter the numbers::");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            var max = Convert.ToInt32(numbers[0]);
            
            foreach(var num in numbers)
            {
                var number = Convert.ToInt32(num);
                if (number > max)
                    max = number;
            }
            Console.WriteLine("Max number is " + max);
        }



    }
}
