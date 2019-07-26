using System;

namespace StaticMethodsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Sqrt(144));
            // Sqrt could be accessed without creating an instance of the Math class.
            // This is an example of a static method.

            Console.ReadLine();
        }
    }
}

// A static method = a method that belongs to the class itself.
// This means you don't need to create an object of that class to be able to access and use it.