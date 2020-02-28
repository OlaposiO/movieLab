using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Midterm;

namespace MidtermTest
{
    public class SearchForMovieTest
    {
            List<Movie> movies = new List<Movie>();
            Movie movie = new Movie();
            List<Movie> movie1 = new List<Movie>();
            SearchForMovie search = new SearchForMovie();
           
        
        [Fact]

        public void DifferentSearches_MainActor_Search()
        {
            //Assemble
            movie.MovieName = "John Wick";
            movie.MainActor = "Keanu Reeves";
            movie.Genre = "Action";
            movie.Director = "Olaposi Omishope";
            movies.Add(movie);
            string actor = "Keanu Reeves";
            string expected = "";

            movie1 = search.SeachByMainActor(actor, movies);
            foreach (var item in movie1)
            {
                 expected = item.MainActor;
            }
            //Action
            string actual = movie.MainActor;

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
       public void DifferentSearches_MovieName_Search()
        {
            //Assemble
            movie.MovieName = "John Wick";
            movie.MainActor = "Keanu Reeves";
            movie.Genre = "Action";
            movie.Director = "Olaposi Omishope";
            movies.Add(movie);
            string movieName = "John Wick";
            string expected = "";

            movie1 = search.SeachByMovieName(movieName, movies);
            foreach (var item in movie1)
            {
                expected = item.MovieName;
            }
            //Action
            string actual = movie.MovieName;

            //Assert
            Assert.Equal(expected, actual);


        }

        [Fact]
        public void DifferentSearches_Genre_Search()
        {
            //Assemble
            movie.MovieName = "John Wick";
            movie.MainActor = "Keanu Reeves";
            movie.Genre = "Action";
            movie.Director = "Olaposi Omishope";
            movies.Add(movie);
            string genreName = "Action";
            string expected = "";

            movie1 = search.SeachByGenre(genreName, movies);
            foreach (var item in movie1)
            {
                expected = item.Genre;
            }
            //Action
            string actual = movie.Genre;

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void DifferentSearches_Director_Search()
        {
            //Assemble
            movie.MovieName = "John Wick";
            movie.MainActor = "Keanu Reeves";
            movie.Genre = "Action";
            movie.Director = "Olaposi Omishope";
            movies.Add(movie);
            string directorName = "Olaposi Omishope";
            string expected = "";

            movie1 = search.SeachByDirector(directorName, movies);
            foreach (var item in movie1)
            {
                expected = item.Director;
            }
            //Action
            string actual = movie.Director;

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
