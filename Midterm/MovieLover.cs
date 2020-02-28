using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Midterm
{
    class MovieLover
    {
        public static MenuOptions GetMenuOption()
        {

            bool ValidChoice;

            Console.WriteLine("What would you like to do? Please select a number from the following:");
            Menu.DisplayMenuOptions();

            do
            {
                switch (Console.ReadLine().ToLower())
                {
                    case "one":
                    case "1":
                        return MenuOptions.DisplayAll;

                    case "two":
                    case "2":
                        return MenuOptions.SearchByMovieName;

                    case "three":
                    case "3":
                        return MenuOptions.SearchByMainActor;
                    case "four":
                    case "4":
                        return MenuOptions.SearchByGenre;
                    case "five":
                    case "5":
                        return MenuOptions.SeachByDirector;
                    case "six":
                    case "6":
                        return MenuOptions.ManageMovies;
                    case "seven":
                    case "7":
                        return MenuOptions.Quit;
                    default:
                        Console.WriteLine("Sorry but that is not a valid input. Please selet a number:");
                        ValidChoice = false;
                        break;
                }
            } while (!ValidChoice);

            return MenuOptions.Quit;
        }

        

        public static List<Movie> MovieLoverSeachMovieName(List<Movie> movieList)
        {
            int i = 1;
            List<string> nameList = new List<string>();
            IEnumerable<string> nameListDistinct;
            foreach (var movie in movieList)
            {
                string name = movie.MovieName.ToString();

                if (!nameList.Contains(name))
                {
                    nameList.Add(name);
                }

            }
            nameListDistinct = nameList.Distinct();

            foreach (var diffname in nameListDistinct)
            {

                Console.WriteLine($"{i} {diffname}");
                i++;
            }


            Console.WriteLine("Please enter the name of the movie you are looking for");
            string userInput = Console.ReadLine();
            var searchFinder = new SearchForMovie();
            var movieSearchResults = searchFinder.SeachByMovieName(userInput, movieList);

            if (movieSearchResults.Count == 0)
            {
                Console.WriteLine("No results found.");
            }
            else
            {
                Console.WriteLine("Here are the results:");
                Menu.DisplayAllMovies(movieSearchResults);
            }
            return movieSearchResults;

        }

        public static List<Movie> MovieLoverSeachMainActor(List<Movie> movieList)
        {
            int i = 1;
            List<string> actorList = new List<string>();
            IEnumerable<string> actorListDistinct;
            foreach (var movie in movieList)
            {
                string actor = movie.MainActor.ToString();
                
                if (!actorList.Contains(actor))
                {
                    actorList.Add(actor);
                }

            }
            actorListDistinct = actorList.Distinct();

            foreach (var diffactor in actorListDistinct)
            {
                
                Console.WriteLine($"{i} {diffactor}");
                i++;
            }
            Console.WriteLine("Please enter the name of the actor you are looking for");
            string userInput = Console.ReadLine();
            var searchFinder = new SearchForMovie();
            var movieSearchResults = searchFinder.SeachByMainActor(userInput, movieList);

            if (movieSearchResults.Count == 0)
            {
                Console.WriteLine("No results found.");
            }
            else
            {
                Console.WriteLine("here are the results:");
                Menu.DisplayAllMovies(movieSearchResults);
            }
            return movieSearchResults;

        }

        public static List<Movie> MovieLoverSeachGenre(List<Movie> movieList)
        {
            int i = 1;
            List<string> genreList = new List<string>();
            IEnumerable<string> genreListDistinct;
            foreach (var movie in movieList)
            {
                string actor = movie.Genre.ToString();

                if (!genreList.Contains(actor))
                {
                    genreList.Add(actor);
                }

            }
            genreListDistinct = genreList.Distinct();

            foreach (var diffgenre in genreListDistinct)
            {

                Console.WriteLine($"{i} {diffgenre}");
                i++;
            }
            Console.WriteLine("Please enter the genre you are looking for");
            string userInput = Console.ReadLine();
            var searchFinder = new SearchForMovie();
            var movieSearchResults = searchFinder.SeachByGenre(userInput, movieList);

            if (movieSearchResults.Count == 0)
            {
                Console.WriteLine("No results found.");
            }
            else
            {
                Console.WriteLine("here are the results:");
                Menu.DisplayAllMovies(movieSearchResults);
            }

            return movieSearchResults;
        }

        public static List<Movie> MovieLoverSearchDirector(List<Movie> movieList)
        {
            int i = 1;
            List<string> directorList = new List<string>();
            IEnumerable<string> directorListDistinct;
            foreach (var movie in movieList)
            {
                string director = movie.MainActor.ToString();

                if (!directorList.Contains(director))
                {
                    directorList.Add(director);
                }

            }
            directorListDistinct = directorList.Distinct();

            foreach (var diffactor in directorListDistinct)
            {

                Console.WriteLine($"{i} {diffactor}");
                i++;
            }

            Console.WriteLine("Please enter the name of the movie you are looking for");
            string userInput = Console.ReadLine();
            var searchFinder = new SearchForMovie();
            var movieSearchResults = searchFinder.SeachByDirector(userInput, movieList);

            if (movieSearchResults.Count == 0)
            {
                Console.WriteLine("No results found.");
            }
            else
            {
                Console.WriteLine("here are the results:");
                Menu.DisplayAllMovies(movieSearchResults);
            }

            return movieSearchResults;
        }

        


    }
}
