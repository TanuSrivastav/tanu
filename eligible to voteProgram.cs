using System;
namespace class Class2
{
    public static void Main4()
    {
        int vote_age;
        Console.Write("\n\n");
        Console.Write("Determine the specific age for voting:\n");
        Console.Write("----------------");
        Console.Write("\n\n");
        Console.Write("Input the age of candidate: ");
        vote_age = Convert.ToInt32(Console.ReadLine());
        if (vote_age < 18)
        {
            Console.Write("You are not eligible to cast your vote. \n");
        }
        else
            Console.Write("you are elegible to vote.\n\n");
        if (vote_age>60)
        {
            Console.Write("You are a senior citizen. \n");
        }

    }
}
