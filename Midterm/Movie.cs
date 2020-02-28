using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    public class Movie
    {

        public string MovieName { get; set; }
        public string MainActor { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }

        public string MovieString { get { return $"{MovieName}, {MainActor}, {Genre}, {Director}"; } }
        public Movie(string movieName, string mainActor, string genre, string director)
        {
            MovieName = movieName;
            MainActor = mainActor;
            Genre = genre;
            Director = director;
        }

        

        public Movie()
        {

        }
    }
}
