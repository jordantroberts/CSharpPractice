using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeChicken();

            Console.ReadLine();
        }
    }
}

// Inheritance is basically a technique we can use in C# where we can have one class inherit all of the functionality from another class.
// We can define a SUPERCLASS and create classes that can inherit all the functionality from that superclass, called subclasses.