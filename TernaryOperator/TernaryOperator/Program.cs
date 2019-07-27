
using System;

namespace TernaryOperator
{
	class Program
	{
		static void Main(string[] args)

        //You’re growing peppers and wrote a program that lets you know if it’s time to pick them.
        //If a pepper is at least 3.5 inches, it’s time to be picked.
        //If it’s not ready, the program should tell you to “wait a little longer”.

        {
            int pepperLength = 4;

			string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";

			Console.WriteLine(message);

		}
	}
}
