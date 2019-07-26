using System;
namespace StaticClassAttributes
{
     class Song
    {
        // Normal attributes on Song class. If you type 'Console.WriteLine(holiday.title)' and Console.WriteLine(kashmir.title) it will print the different titles for each Song.
        public string title;
        public string artist;
        public int duration;

        public Song(string aTitle, string aAttist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
        }
    }
}
