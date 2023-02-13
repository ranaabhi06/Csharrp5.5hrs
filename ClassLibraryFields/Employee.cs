using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryFields
{
    public class Employee
    {
        //fields
        public int EmpId;
        public string EmpName;
        public int SalaryPerHour;
        public int NoOfWorkingDays;
        public long NetSalary;

        //fields with modifier's

        //static field
        public static string OrganzationName;

        //constants field
        public const string TypeOfEmployee = "Contract Based";

        //readonly fields
        public readonly string DepartmentName;

        //In Constructor

        public Employee()
        {
            DepartmentName = "Finance Department";
        }


    }
}
