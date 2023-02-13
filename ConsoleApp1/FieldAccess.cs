using ClassLibraryFields;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class FieldAccess
    {
        public static void Main()
        {
            Employee.OrganzationName = "Harsha Inc.";

            System.Console.WriteLine("****" + Employee.OrganzationName + "****");


            for (int i = 0; i < 10; i++)
            {
                string EmpNum;
                switch (i)
                {
                    case 0: EmpNum = "First Employee"; break;
                    case 1: EmpNum = "Second Employee"; break;
                    case 2: EmpNum = "Third Employee"; break;
                    case 3: EmpNum = "Fourth Employee"; break;
                    case 4: EmpNum = "Fifth Employee"; break;
                    case 5: EmpNum = "Sixth Employee"; break;
                    case 6: EmpNum = "Seventh Employee"; break;
                    case 7: EmpNum = "Eighth Employee"; break;
                    case 8: EmpNum = "Ninth Employee"; break;
                    case 9: EmpNum = "Tenth Employee"; break;
                    default: EmpNum = "Other Employee"; break;

                }

                System.Console.WriteLine(EmpNum);

                Employee emp = new Employee();
                System.Console.Write("Employee ID: ");
                emp.EmpId = Convert.ToInt32(System.Console.ReadLine());

                System.Console.Write("Employee Name: ");
                emp.EmpName = System.Console.ReadLine();

                System.Console.WriteLine("Salary Per Hour: ");
                emp.SalaryPerHour = Int32.Parse(System.Console.ReadLine());

                System.Console.WriteLine("No. of Working Hours: ");
                emp.NoOfWorkingDays = Int32.Parse(System.Console.ReadLine());

                emp.NetSalary = emp.NoOfWorkingDays * emp.SalaryPerHour;

                //Employee Details

                System.Console.WriteLine("\nDetails Of " + EmpNum);
                System.Console.WriteLine("Employee Id " + emp.EmpId);
                System.Console.WriteLine("Employee Name " + emp.EmpName);
                System.Console.WriteLine("Salary Per hour" + emp.SalaryPerHour);
                System.Console.WriteLine("Number of working hours " + emp.NoOfWorkingDays);
                System.Console.WriteLine("Net Salary " + emp.NetSalary);
                System.Console.WriteLine("Type of Employee " + Employee.TypeOfEmployee);
                System.Console.WriteLine("Department Name " + emp.DepartmentName);

                System.Console.Write("Do you want to continue to next employee? (yes/no) ");
                string choice = System.Console.ReadLine();

                if (choice == "no" || choice == "NO" || choice == "n" || choice == "N")
                {
                    break;
                }
                System.Console.WriteLine("_____----------_____");


            }

            System.Console.WriteLine("\nThankYou.");
            System.Console.ReadKey();
           
        }
    }
}
