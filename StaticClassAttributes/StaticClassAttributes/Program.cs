using System;

namespace StaticClassAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

            Console.WriteLine(Song.songCount);
            // can call songCount as it's an attribute of the Song class. You cannot call "Song.title" for example

            Console.ReadLine(); 

        }
    }
}
