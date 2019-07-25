using System;

namespace Strings
{
    class Stringy
    {
        static void Main()
        {
            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Konnichiwa");
            Console.WriteLine(sayHello);
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());
        }
    }
}

// Output:

//Hello World!
//Konnichiwa World!
//KONNICHIWA WORLD!
//konnichiwa world!
