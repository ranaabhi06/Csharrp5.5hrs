
class Program
{
    static void Mainly()
    {
       
        System.Console.WriteLine("**************// Swiss Bank //*****************");
        System.Console.WriteLine("::Login Page::");
        //var a = ConsoleApp1.Class1.hello();
        //System.Console.WriteLine(a);


        
        string userName = null, password = null;

        
        System.Console.Write("Username: ");
        userName = System.Console.ReadLine();
        //System.Console.WriteLine("Successful__:");
        
        if (userName != "")
        {
            System.Console.Write("Password: ");
            password = System.Console.ReadLine();
        }

        
        if (userName == "system" && password == "manager")
        {
            int mainMenu = -1;
            do
            {
                System.Console.WriteLine("\n::Main Menu::");
                System.Console.WriteLine("1.Customers");
                System.Console.WriteLine("2.Accounts");
                System.Console.WriteLine("3.Fund Transfers");
                System.Console.WriteLine("4.Fund Transfers Statement");
                System.Console.WriteLine("5.Account Statement");
                System.Console.WriteLine("0.Exit");

                System.Console.WriteLine("Enter Choice");
                mainMenu = int.Parse(System.Console.ReadLine());

                switch (mainMenu)
                {
                    case 1: CustomerMenu();
                        break;
                    case 2: AccountMenu();
                        break;
                }


            } while (mainMenu != 0);



            static void CustomerMenu()
            {
                int customer_choice = -1;
                do
                {
                    System.Console.WriteLine("\n::Customer Menu::");
                    System.Console.WriteLine("1.Add Customer");
                    System.Console.WriteLine("2.Delete Customer");
                    System.Console.WriteLine("3.Update Customer");
                    System.Console.WriteLine("4.View Customer");
                    System.Console.WriteLine("0.Back to main menu");

                    System.Console.WriteLine("Enter Choice: ");
                    customer_choice = System.Convert.ToInt32(System.Console.ReadLine());

                } while (customer_choice != 0);

             
                
                
                
                
                
                
                
                }
                
            static void AccountMenu()
            {
                int Account_choice = -1;
                do
                {
                    System.Console.WriteLine("\n::Account Menu::");
                    System.Console.WriteLine("1.Add Account");
                    System.Console.WriteLine("2.Delete Account");
                    System.Console.WriteLine("3.Update Account");
                    System.Console.WriteLine("4.View Account");
                    System.Console.WriteLine("0.Back to main menu");

                    System.Console.WriteLine("Enter Choice: ");
                    Account_choice = System.Convert.ToInt32(System.Console.ReadLine());

                } while (Account_choice != 0);
            }


        }

        
        System.Console.WriteLine("Thank you! Visit again.");
        System.Console.ReadKey();
    }
}