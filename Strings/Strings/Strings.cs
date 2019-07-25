using System;

namespace Strings
{
    class Stringy
    {
        static void Main()
        {
            string songLyrics = "We will we will rock you";
            Console.WriteLine(songLyrics.StartsWith("We"));
            Console.WriteLine(songLyrics.StartsWith("we"));
            Console.WriteLine(songLyrics.StartsWith("rock"));
            Console.WriteLine(songLyrics.EndsWith("you"));
        }
    }
}

// Output:

//True
//False
//False
//True