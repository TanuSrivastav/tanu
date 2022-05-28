using System;

namespace ConsoleApp26
{
    class Program
    {
        static void swap(ref int x, ref int y)
        {
            int tempswap = x;
            x = y;
            y = tempswap;
        }
        static void Main(string[] args)
        {
            int a = 5, b = 6;
            Console.WriteLine("a =" + " " + a);
            Console.WriteLine("b=" + " " + b);
            swap(ref a, ref b);
            Console.WriteLine();
            Console.WriteLine("Value of a, b after swapping");
            Console.WriteLine();
            Console.WriteLine("a=" + " " + a);
            Console.WriteLine("b=" + " " +b);
            Console.ReadLine();
        


 
                           
               

        }
    }
}
