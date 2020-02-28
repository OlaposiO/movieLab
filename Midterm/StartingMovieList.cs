using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    public static class StartingMovieList
    {
        public static List<Movie> CreateStartingMovieList()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie("Civil War", "Chris Evans", "Action", "Kevin Feige"),
                new Movie("Thor: Ragnarok", "Chris Himmingworth", "Action", "Kevin Feige"),
                new Movie("Captail Marvel", "Brie Larson", "Action", "Kevin Feige"),
                new Movie("SpiderMan: Far from Home", "Tom Holland", "Action", "Kevin Feige"),
                new Movie("Heroes Rising", "MHA", "Anime", "Bones"),
                new Movie("Two Heroes", "MHA", "Anime", "Bones"),
                new Movie("Dead Apple", "Bungo Stray Dogs", "Anime", "Bones"),
                new Movie("Phoenix Priestess", "FairyTail", "Anime", "A-1 Studios"),
                new Movie("Book of Atlantic", "Black Butler", "Anime", "A-1 Studios"),
                new Movie("Ordinal Scale", "SAO", "Anime", "A-1 Studios"),
                new Movie("Batman Begins", "Christain Bale", "Action", "Chistopher Nolan"),
                new Movie("Inception", "Leonardo DiCaprio","Thiller", "Chrisopher Nolan"),
                new Movie("The Dark Knight", "Christain Bale","Action", "Chrisopher Nolan"),
                new Movie("Memento", "Guy Pearce","Thiller", "Chrisopher Nolan"),
                new Movie("Get Out", "Daniel Kaluuya", "Thiller", "Jordan Peele"),
                new Movie("Split", "David Dunn", "Thiller", "M. Kight Shyamalan")
            };

            SaveLoad.Save(movies);
            return movies;
        }
    }
}
