using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class sample
    {
        public int a;
    }

    class Employee
    {
        public string EmployeeName;
        public int EmployeeId;
        public string EmployeeGender;

        //get Input from User

        //Methods in a class
        public void GetData()
        {
            Console.WriteLine("Please enter Employee  Details");
            Console.WriteLine("Please enter Employee Name");
            EmployeeName = Console.ReadLine();
            Console.WriteLine("Please enter Employee ID");
            EmployeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Employee Gender ");
            EmployeeGender = Console.ReadLine();
        }

        public void PrintData()
        {
            Console.WriteLine("Employee Details are");
            Console.WriteLine(EmployeeName);
            Console.WriteLine(EmployeeId);
            Console.WriteLine(EmployeeGender);
        }
    }

    class Class5
    {
        static void Main(string[] args)
        {
            Employee[] Employeelist = new Employee[3];
            for (int i = 0; i < Employeelist.Length; i++)
            {
                Employee s = new Employee();
                s.GetData();
                Employeelist[i] = s;
            }

            for (int i = 0; i < Employeelist.Length; i++)
            {
                Employeelist[i].PrintData();
            }

        }
    }
}