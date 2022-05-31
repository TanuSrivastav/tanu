using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{

    class CalculatorA
    {
        public int Number1, Number2;

        public void CalculatorA(int num1, int num2)
        {
            Number1 = num1;
            Number2 = num2;
        }

        public void Print()
        {
            Console.WriteLine("Number 1=" + Number1);
            Console.WriteLine("Number 2=" + Number2);
        }

        public static CalculatorA operator *(CalculatorA c1, CalculatorA c2)
        {
            CalculatorA c3 = new Calculator(0, 0);
            c3.Number1 = c1.Number1 * c2.Number1;
            c3.Number2 = c1.Number2 * c2.Number2;
            return c3;
        }
    }
    class Class2
    {
        public static void Main5()
        {
            CalculatorA calculator1 = new Calculator(15, 20);
            CalculatorA calculator2= new Calculator(20, 20);
            CalculatorA calculator3 = new Calculator(0, 0);
            calculator3 = calculator1 * calculator2;
            calculator3.Print();
        }
    }
}
