using System;

namespace Strings
{
    class Stringy
    {
        static void Main()
        {
            string reverseMe = "Hello world!";

            for (int i = 0; i < reverseMe.Length; i++)
            {
                Console.Write(reverseMe[reverseMe.Length - i - 1]);
            }
        }
    }   
}
