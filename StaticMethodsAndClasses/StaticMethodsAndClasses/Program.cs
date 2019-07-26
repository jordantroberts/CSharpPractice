﻿using System;

namespace StaticMethodsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            UsefulTools.SayHi("Jordan");

            // Didn't actually have to create an instance of the UsefulTools class!

            Console.ReadLine();
        }
    }
}

// A static method = a method that belongs to the class itself.
// This means you don't need to create an object of that class to be able to access and use it.