using System;

namespace Strings
{
    class Stringy
    {
        static void Main()
        {
            string songLyrics = "We will we will rock you";
            Console.WriteLine(songLyrics.Contains("rock"));
            Console.WriteLine(songLyrics.Contains("eat"));
        }
    }
}

// Output:

//True
//False