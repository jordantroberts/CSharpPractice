using System;
namespace StaticClassAttributes
{
     class Song
    {
        // Normal attributes on Song class. If you type 'Console.WriteLine(holiday.title)' and Console.WriteLine(kashmir.title) it will print the different titles for each Song.
        // Each song will have its own title, its own artist and own duration. These things will differ across objects. 
        public string title;
        public string artist;
        public int duration;
        // Another type of attribute is a static attribute, which isn't unique to each of the objects.
        // In other words, a static attribute is an attribute about the actual class. Will be the same across all of the objects of the class.
        // Create a static attribute to tell us how many song objects have been created:
        public static int songCount = 0;

        // This is a constructor method - any time a Song object gets created, this method is called. 
        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            // every time we create a song, let's increment the song count:
            songCount ++ 
        }
    }
}


