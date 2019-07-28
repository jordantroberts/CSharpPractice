﻿using System;

namespace UsingOut
{
    class Program
    {
        static void Main(string[] args)
        {
            string statement = "GARRRR";
            string murmur = Whisper(statement, out bool marker);
            Console.WriteLine(murmur);
            Console.WriteLine(marker);
        }

        static string Whisper(string phrase, out bool wasWhisperCalled)
        {
            wasWhisperCalled = true;
            return phrase.ToLower();
        }
    }
}


// Output:
// garrr
// True