using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    class Menu
    {
        public static void DisplayMenuOptions()
        {
            Console.WriteLine("1. Display all Movies");
            Console.WriteLine("2. Search By Movie Name");
            Console.WriteLine("3. Search By Main Actor");
            Console.WriteLine("4. Search By Genre");
            Console.WriteLine("5. Seach By Director");
            Console.WriteLine("6. Manage Movies");
            Console.WriteLine("7. Quit\n");

        }

        public static void DisplayAllMovies(List<Movie> movies)
        {
            int i = 1;
            Console.WriteLine("===============================================================================");
            Console.WriteLine($"      {"Movie",-26} {"Actor",-20} {"Genre",-8} {"Director", -10}");
            Console.WriteLine("===============================================================================");
            foreach (Movie movie in movies)
            {
                Console.WriteLine($"{i,5} {movie.MovieName, -26} {movie.MainActor, -20} {movie.Genre, -8} {movie.Director,-10}  ");
                i++;
            }
            Console.WriteLine();
        }
    }
}
