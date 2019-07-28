using System;

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


// Although the Whisper function is returning just one string, it will also set the value of wasWhisperCalled.
// So if wasWhisperCalled was false before function call, then after the function call it will be set to true.

