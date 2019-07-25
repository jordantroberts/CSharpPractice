using System;

namespace Strings
{
    class Stringy
    {
        static void Main()
        {
            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            string greeting2 = greeting.Trim();
            Console.WriteLine($"[{greeting2}]");
        }
    }
}

// Output:
//[Hello World!       ]
//[Hello World!       ]
//[Hello World!]
//[Hello World!]
