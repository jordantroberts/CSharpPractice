using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task: see if you can write C# code to find the sum of all integers 1 through 20 that are divisible by 3.

            int total = 0;

            for (int counter = 0; counter <= 20; counter++)
            {
                if (counter % 3 == 0)
                {
                    total += counter;
                }
            }
            Console.WriteLine(total);
        }
    }
}

