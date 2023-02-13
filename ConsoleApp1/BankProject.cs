using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class BankProject
    {
        public static void Main_Bank()
        {
            System.Console.WriteLine("**********BANK_PROJECT*************");
            System.Console.WriteLine("::Login Page::");

            string userName = null, password = null;

            System.Console.Write("::UserName::");
            userName = System.Console.ReadLine();

            if (userName !="")
            {
                System.Console.Write("::PassWord::");
                password = System.Console.ReadLine();
            }

            if (userName == "system" && password == "manager")
            {
                int mainMenuChoice = -1;

                do
                {


                    System.Console.WriteLine("******________Main Menu________******");
                    System.Console.WriteLine("*********1.Customers******");
                    System.Console.WriteLine("*********2.Accounts******");
                    System.Console.WriteLine("*********3.Fund Transfer******");
                    System.Console.WriteLine("*********4.Fund Transfer Statement******");
                    System.Console.WriteLine("*********5.Account Statement******");
                    System.Console.WriteLine("*********0.Exit******");

                    System.Console.Write("Enter Choice");
                    mainMenuChoice = Convert.ToInt32(System.Console.ReadLine());

                    //switch case for choices

                    switch (mainMenuChoice)
                    {
                        case 1:CustomersMenu();
                            break;
                        case 2:AccountMenu();
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                    }
                } while (mainMenuChoice != 0);
            }
            else
            {
                System.Console.WriteLine("Invalid username or password");
            }
            System.Console.WriteLine("Thankyou Visit Again.");
            System.Console.ReadKey();
          
        }

        static void CustomersMenu()
        {
            int customerMenuChoice = -1;
            do
            {
                System.Console.WriteLine("\n::::Customers Menu::::");
                System.Console.WriteLine("1.Add Customer");
                System.Console.WriteLine("2.Delete Customer");
                System.Console.WriteLine("3.Update Customer");
                System.Console.WriteLine("4.View Customers");
                System.Console.WriteLine("0:Back to Main Menu");

                System.Console.Write("::Enter choice::");
                customerMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

            } while (customerMenuChoice != 0);
        }

        static void AccountMenu()
        {
            int accountMenuChoice = -1;
            do
            {
                System.Console.WriteLine("\n::::Accounts Menu::::");
                System.Console.WriteLine("1.Add Account");
                System.Console.WriteLine("2.Delete Account");
                System.Console.WriteLine("3.Update Account");
                System.Console.WriteLine("4.View Accounts");
                System.Console.WriteLine("0:Back to Main Menu");

                System.Console.Write("Enter choice::");
                accountMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

            } while (accountMenuChoice != 0);
        }


    }

}
