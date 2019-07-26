using System;

namespace Numbers
{
    class Program
    {
        static void Main()
        {
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            // The M suffix is how you indicate that a constant should use the decimal type. 
            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
        }
    }
}

// Output:

// 0.333333333333333
// 0.3333333333333333333333333333

// Using a decimal type has more digits to the right of the decimal point.
// The decimal type has a smaller range but greater precision than a double.