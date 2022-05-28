using System;

namespace SwappingValues
{
    class Program2
    {
        static void swapnum(ref int x, ref int y)
        {
            int tempswap = x;
            x = y;
            y = tempswap;
        }
        static void Main2(string[] args)
        {
            int a = 5, b = 6;
            Console.WriteLine("a =" + " " + a);
            Console.WriteLine("b=" + " " + b);
            swapnum(ref a, ref b);
            Console.WriteLine();
            Console.WriteLine("Value of a, b after swapping");
            Console.WriteLine();
            Console.WriteLine("a=" + " " + a);
            Console.WriteLine("b=" + " " +b);
            Console.ReadLine();
        }
    }
}
