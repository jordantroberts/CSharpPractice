using System;

namespace StaticClassAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(kashmir.getSongCount());
            Console.ReadLine(); 

        }
    }
}

