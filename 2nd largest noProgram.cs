using System;
using System.Collections;

public class Program3
{
    public static void Main3()
    {
        int[] array = { 87, 4, 66, 26, 45, 72, 99 };
        Array.Sort(array); //sorting array
        Array.Reverse(array); //reverse sorting array value
        Console.WriteLine("\n Second Highest value in aray: " + array[1]);
        foreach(var result in array)
        {
            Console.Write(result + "" ); //Array values
        }

    }
}
