
using System;
using System.Linq;

public class Example
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 2, 4, 5, 2, 4 };

        var duplicates = arr.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => y.Key)
              .ToList();

        Console.WriteLine(String.Join(", ", duplicates));        // 2, 4
    }
}
