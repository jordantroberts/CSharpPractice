using System;

namespace StaticMethodsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Sqrt(144));

            Console.ReadLine();
        }
    }
}

// A static method = a method that belongs to the class itself.
// This means you don't need to create an object of that class to be able to access and use it.