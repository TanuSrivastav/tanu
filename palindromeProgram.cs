using System;

namespace palindrome
{
    class Program2
    {
        static void Main2(string[] args)
        {
            string s, revs = "";
            Console.WriteLine(" Enter String");
            s = Console.ReadLine();
            for (int i=s.Length-1; i>= 0; i--)
                //string reverse
                {
                revs += s[i].ToString();
            }
            if (revs==s) // checking whether the string is palindrome or not
            {
                Console.WriteLine("string is palindrome \n Entered string was {0} and reverse string is {1}", s, revs);
            }
            else
            {
                Console.WriteLine("string is not palindrome \n Entered string was {0} and reverse string is {1}", s, revs);
            }
            Console.ReadKey();

                


        }
    }
}
