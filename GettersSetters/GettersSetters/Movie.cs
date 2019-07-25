using System;

namespace GettersSetters
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }
        // Getter and Setter for rating attribute to allow outside code, such as code in Program class, to both access the rating and modify and set the rating.
        // Define these through properties. Properties are sort of like methods but is a special method that will allow us to define our getter and setter.
        // Usually name it same as the attribute but with capital letter:
        public string Rating
        {
            // define two things, get and set:
            get { return rating; }
            set {
                // if the value they're trying to set it to is a valid rating, they can, else they cannot.
                if(value == "PG" || value == "12" || value == "15" || value == "18")
                {
                    rating = value;
                }
                else
                {
                    rating = "Not rated";
                }
                    // value represents whatever they're passing in, aka whatever they're trying to set the rating to.
             }
        }
    }
}
