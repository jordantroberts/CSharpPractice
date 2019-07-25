using System;

namespace Strings
{
    class Stringy
    {
        static void Main()
        {
            string aFriend = "Amy";
            string newFriend = "Steve";
            Console.WriteLine($"My friends are {aFriend} and {newFriend}");
            Console.WriteLine($"The name {aFriend} has {aFriend.Length} letters.");
            Console.WriteLine($"The name {newFriend} has {newFriend.Length} letters.");
            Console.WriteLine($"Hey, {aFriend.Replace("Amy", "Rhiannon")}");
        }
    }
}
