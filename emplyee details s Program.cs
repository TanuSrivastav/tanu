using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
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
        public int Salary;
    }

    class Class5
    {
        static void Main(string[] args)
        {
            sample s1 = new sample();
            s1.a = 6;

            Console.WriteLine(s1.a);

          Employee s = new Employee();
            s.EmployeeName = "Tanu";
            s.EmployeeId = 46235372;
            s.EmployeeGender = "F";
            s.Salary = 21500;



            Console.WriteLine("Employee Details are");
            Console.WriteLine(s.EmployeeName);
            Console.WriteLine(s.EmployeeId);
            Console.WriteLine(s.EmployeeGender);
            Console.WriteLine(s.Salary);
        }
    }
}
