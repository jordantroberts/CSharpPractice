using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello world! The counter is {counter}");
                counter++;
            }
        }
    }
}

//Output = 
//Hello world! The counter is 0
//Hello world! The counter is 1
//Hello world! The counter is 2
//Hello world! The counter is 3
//Hello world! The counter is 4
//Hello world! The counter is 5
//Hello world! The counter is 6
//Hello world! The counter is 7
//Hello world! The counter is 8
//Hello world! The counter is 9