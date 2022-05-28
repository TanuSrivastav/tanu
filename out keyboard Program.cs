
using System;

class GFG1
{

    // Main method
    static public void Main1()
    {

        // Declaring variable
        // without assigning value
        int G;

        // Pass variable G to the method
        // using out keyword
        Sum(out G);

        // Display the value G
        Console.WriteLine("The sum of" +
                " the value is: {0}", G);
    }

    // Method in which out parameter is passed
    // and this method returns the value of
    // the passed parameter
    public static void Sum(out int G)
    {
        G = 80;
        G += G;
    }
}