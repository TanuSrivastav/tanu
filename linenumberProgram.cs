using System;
class NumberPattern
{
    public static void Main()
    {
        int number = 5;
        for (int i=1; i<=5; i++)
        {
            for (int j = 1; j <= 1; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}