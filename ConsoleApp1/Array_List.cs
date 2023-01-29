//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp1
//{
//    class Array_List
//    {

//        public static void exercise1()
//        {
//            var names = new List<String>();

//            while (true)
//            {
//                Console.Write("Type a name or Press Enter to exit:");

//                var input = Console.ReadLine();
//                if (String.IsNullOrWhiteSpace(input))
//                    break;
//                names.Add(input);
//            }
//            if (names.Count > 2)
//                Console.WriteLine("{0} ,{1} and {2} others like your post ", names[0], 
//                    names[1], names.Count-2);
//            else if (names.Count == 2)
//                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
//            else if (names.Count == 1)
//                Console.WriteLine("{0} likes your post.", names[0]);
//            else
//                Console.WriteLine("No one likes YOU");
//        }

//        public static void exercise2()
//        {
//            Console.WriteLine("Please enter your name? ");
//            var name = Console.ReadLine();

//            var array = new char[name.Length];

//            for(var i = name.Length; i > 0; i--)
//            {
//                array[name.Length - i] = name[i - 1];
//            }
//            var reversed = new string(array);
//            Console.WriteLine("Reversed array is " + reversed);
//        }


//        public static void exercise3()
//        {
//            var numbers = new List<int>();
//            while (numbers.Count < 5)
//            {
//                Console.WriteLine("Enter a number: "); ;
//                var number = Convert.ToInt32(Console.ReadLine());
//                if(numbers.Contains(number))
//                {
//                    Console.WriteLine("You entered {0} earlier ", number);
//                    continue;
//                }
//                numbers.Add(number);
//            }
//            numbers.Sort();

//            foreach (var i in numbers)
//                Console.Write(i+" ");
//        }

//        public static void exercise4()
//        {
//            var numbers = new List<int>();
//            while (true)
//            {
//                Console.Write("Enter a number or write QUIT to exit:::");
//                var input = Console.ReadLine();
//                if (input.ToLower() == "quit")
//                    break;

//                numbers.Add(Convert.ToInt32(input));
//            }
//            var unique = new List<int>();
//            foreach (var number in numbers)
//                if (!unique.Contains(number))
//                    unique.Add(number);

//            Console.WriteLine("Unique numbers are :::");
//            unique.Sort();
//            foreach (var i in unique)
//                Console.Write(" " + i + " ");
//        }

//        public static void exercise5()
//        {
//            string[] elements;
//            while (true)
//            {
//                Console.Write("Enter a list of comma seperated numbers:::");
//                var input = Console.ReadLine();
//                if(!String.IsNullOrWhiteSpace(input))
//                {
//                    elements = input.Split(',');
//                    if (elements.Length >= 5)
//                        break;
//                }
//                Console.WriteLine("Invalid List");
//            }
//            var numList = new List<int>();
//            foreach (var number in elements)
//                numList.Add(Convert.ToInt32(number));

//            numList.Sort();
//            for(int i = 0; i < 3; i++)
//            {
//                Console.WriteLine("Smallest numbers are:::"+numList[i]);
//            }

//        }
//        public static void Main3()
//        {
//            Console.WriteLine("Array and List");
//            //Array_List.exercise1();
//            //Array_List.exercise2();
//            //Array_List.exercise3();
//            //Array_List.exercise4();
//            Array_List.exercise5();
//        }
//    }
//}
