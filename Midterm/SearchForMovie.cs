using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    public class SearchForMovie
    {
        public List<Movie> SeachByMovieName(string userInput, List<Movie> movieList)
        {
            List<Movie> moviesResult = new List<Movie>();

            foreach (Movie item in movieList)
            {
                if (item.MovieName.Contains(userInput, StringComparison.OrdinalIgnoreCase))
                {
                    moviesResult.Add(item);
                }
            }

            return moviesResult;
        }

        public List<Movie> SeachByMainActor(string userInput, List<Movie> movieList)
        {
            List<Movie> moviesResult = new List<Movie>();

            foreach (Movie item in movieList)
            {
                if (item.MainActor.Contains(userInput, StringComparison.OrdinalIgnoreCase))
                {
                    moviesResult.Add(item);
                }
            }

            return moviesResult;
        }


        public List<Movie> SeachByGenre(string userInput, List<Movie> movieList)
        {
            List<Movie> moviesResult = new List<Movie>();

            foreach (Movie item in movieList)
            {
                if (item.Genre.Contains(userInput, StringComparison.OrdinalIgnoreCase))
                {
                    moviesResult.Add(item);
                }
            }

            return moviesResult;
        }

        public List<Movie> SeachByDirector(string userInput, List<Movie> movieList)
        {
            List<Movie> moviesResult = new List<Movie>();

            foreach (Movie item in movieList)
            {
                if (item.Director.Contains(userInput, StringComparison.OrdinalIgnoreCase))
                {
                    moviesResult.Add(item);
                }
            }

            return moviesResult;
        }

        
    }
}
