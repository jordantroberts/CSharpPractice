using System;

namespace UsingOut
{
    class Program
    {
        static void Main(string[] args)
        {
            ReturnMultiple(1, out 1, out 2);
        }

        public int ReturnMultiple(int input, out int output1, out int output2)
        {
            output1 = input + 1;
            output2 = input + 2;

            return input;
        }
    }
}


// Output:
// garrr


// Although the Whisper function is returning just one string, it will also set the value of wasWhisperCalled.
// So if wasWhisperCalled was false before function call, then after the function call it will be set to true.

