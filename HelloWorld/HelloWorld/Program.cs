using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting greeting = new Greeting();
            Console.WriteLine(greeting.HelloWorld());
            
        }
    }

    public class Greeting
    {
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
