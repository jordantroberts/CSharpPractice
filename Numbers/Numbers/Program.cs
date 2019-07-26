using System;

namespace Numbers
{
    class Program
    {
        static void Main()
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c; 
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"quotient: {e}");

            
        }
    }
}

// Output:

    // 3
    // 2 