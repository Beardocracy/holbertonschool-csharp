using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                string output = "";
                if (i % 3 == 0)
                {
                    output += "Fizz";
                }
                if (i % 5 == 0)
                {
                    output += "Buzz";
                }
                if ((i % 3 != 0) && (i % 5 != 0))
                {
                    output += i.ToString();
                }
                if (i < 100)
                {
                    output += ", ";
                }
                Console.Write(output);
            }
            Console.WriteLine();
        }
    }
}
