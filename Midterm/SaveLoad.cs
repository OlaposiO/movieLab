using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Midterm
{
    public static class SaveLoad
    {
                
        public static void Save(List<Movie> movieList )
        {
            using (var writer = new StreamWriter(@"MoviesList.txt", false))
            {

                IEnumerable<Movie> orderList = movieList.OrderBy(Movie => Movie.MovieName).ToList();
                foreach (var item in orderList)
                {
                    string movieName = item.MovieName;
                    string mainActor = item.MainActor;
                    string genre = item.Genre;
                    string director = item.Director;

                    string movieString = ($"{movieName}//{mainActor}//{genre}//{director}");

                    writer.WriteLine(movieString);
                }
            }
        }

        public static List<Movie> Load()
        {
            bool createList = !File.Exists(@"MoviesList.txt");
            if (createList)
            {
                StartingMovieList.CreateStartingMovieList();
            }

            using (var reader = new StreamReader(@"MoviesList.txt"))
            {
                var file = reader.ReadToEnd();
                var lines = file.Split("\n");

                List<Movie> _MovieList = new List<Movie>();

                foreach (var line in lines)
                {
                    string[] movieDetails = line.Split("//");

                    if (movieDetails.Length == 4)
                    {
                        string movieName = movieDetails[0];
                        string mainActor = movieDetails[1];
                        string genre = movieDetails[2];
                        string director = movieDetails[3];

                        _MovieList.Add(new Movie(movieName, mainActor, genre, director));
                    }
                }

                return _MovieList;
            }

        }
    }
}
