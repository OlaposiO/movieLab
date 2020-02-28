using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Midterm;

namespace MidtermTest
{
    public class AddAndRemoveTest
    {
        [Fact]

        public void AddTest()
        {
        List<Movie> movies = new List<Movie>();
        Movie movie = new Movie();
        List<Movie> movie1 = new List<Movie>();
//        AddAndRemoveMovie addAndRemove = new AddAndRemoveMovie();
        
            string movieName = "John Wick";
            string actor = "Keanu Reeves";
            string genre = "Action";
            string director = "Olaposi";

            movie.MovieName = movieName;
            movie.MainActor = actor;
            movie.Genre = genre;
            movie.Director = director;

            movies.Add(movie);

            List<Movie> expectedMovies; 
           // movie1 = AddAndRemoveMovie.AddMovie(movies);


        }


    }
}
