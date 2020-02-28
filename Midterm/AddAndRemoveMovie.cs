using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    public static class AddAndRemoveMovie
    {
        public static void ManageMovie(List<Movie> movies)
        {
            Console.Clear();
            Console.WriteLine("How would you like to manage this Library?");
            Console.Write("1. Add a movie. \n2. Remove a movie. \n3. Go back to main menu\n>");

            bool validInput = false;

            do
            {
                string userInput = Console.ReadLine();
                if (userInput.Equals("1"))
                {
                    AddMovie(movies);
                    validInput = true;
                }
                else if (userInput.Equals("2"))
                {
                    RemoveMovie(movies);
                    validInput = true;
                }
                else if (userInput.Equals("3"))
                {

                    validInput = true;
                }
                else
                {
                    Console.WriteLine("I am sorry that was not a vaild input please try again");
                    validInput = false;
                }
            } while (!validInput);
            return;
        }

        //public static string MovieInfoInput(string userInput, string slot)
        //{
        //    Console.Write($"Please enter {slot}: ");
        //    do
        //    {
        //        userInput = Console.ReadLine();
        //        if (userInput == "")
        //        {
        //            Console.WriteLine($"Please enter the {slot}.");
        //            Console.Write($"{slot}: ");
        //        }
        //        if (userInput.Contains("//"))
        //        {
        //            Console.WriteLine($"Apologiges. The {slot} can not contain '//'.");
        //            Console.Write($"{slot}: ");
        //        }
        //    } while (userInput == "" || userInput.Contains("//"));

        //    return userInput;

        //}

        public static void AddMovie(List<Movie> movies)
        {
            string movieName;
            string mainActor;
            string genre;
            string director;
           
            //MovieInfoInput(movieName, "movie name");
            //MovieInfoInput(mainActor, "lead actor");
            //MovieInfoInput(genre, "genre");
            //MovieInfoInput(director, "director");

            Console.Clear();

            Console.Write($"Please enter the movie name: ");
            do
            {
                movieName = Console.ReadLine();
                if (movieName == "")
                {
                    Console.WriteLine($"Please enter the movie name.");
                    Console.Write($"Name of moive?: ");
                }
                if (movieName.Contains("//"))
                {
                    Console.WriteLine($"Apologiges. The movie name can not contain '//'.");
                    Console.Write($"Name of movie: ");
                }
            } while (movieName == "" || movieName.Contains("//"));

            
            Console.Write($"Please enter the lead actor's name: ");
            do
            {
                mainActor = Console.ReadLine();
                if (mainActor == "")
                {
                    Console.WriteLine($"Please enter the movie name.");
                    Console.Write($"Name of moive?: ");
                }
                if (mainActor.Contains("//"))
                {
                    Console.WriteLine($"Apologiges. The movie name can not contain '//'.");
                    Console.Write($"Name of movie: ");
                }
            } while (mainActor == "" || mainActor.Contains("//"));

           
            
            Console.Write($"Please enter the movie's genre : ");
            do
            {
                genre = Console.ReadLine();
                if (genre == "")
                {
                    Console.WriteLine($"Please enter the movie name.");
                    Console.Write($"Name of moive?: ");
                }
                if (genre.Contains("//"))
                {
                    Console.WriteLine($"Apologiges. The movie name can not contain '//'.");
                    Console.Write($"Name of movie: ");
                }
            } while (genre == "" || genre.Contains("//"));


            Console.Write($"Please enter the movie's director: ");
            do
            {
                director = Console.ReadLine();
                if (director == "")
                {
                    Console.WriteLine($"Please enter the movie name.");
                    Console.Write($"Name of moive?: ");
                }
                if (director.Contains("//"))
                {
                    Console.WriteLine($"Apologiges. The movie name can not contain '//'.");
                    Console.Write($"Name of movie: ");
                }
            } while (director == "" || director.Contains("//"));

            Movie movie = new Movie(movieName, mainActor, genre, director);
            movies.Add(movie);

            Console.Clear();
            Console.WriteLine($"{movie.MovieName.ToString()} starring {movie.MainActor.ToString()} was added!");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            return;
        }

        public static void RemoveMovie(List<Movie> movies)
        {
            
                
            bool validOption = false;

            Console.Clear();
            Menu.DisplayAllMovies(movies);
            do
            {
                Console.WriteLine("Please select which movie you'd like to remove by number.");
                validOption = int.TryParse(Console.ReadLine(), out int num);
                Movie movie1 = new Movie();
                movie1 = movies[num - 1];

                if (validOption == true)
                {
                    movies.Remove(movie1);
                    validOption = true;
                    Console.WriteLine($"{movie1.MovieName.ToString()} was removed");
                }
                else
                {
                    Console.WriteLine("I'm sorry that was not a valid input.");
                    validOption = false;
                }



                //foreach (var movie in movies)
                //{
                //    if (validOption == true)
                //    {
                //        movies.Remove(movie1);
                //        validOption = true;
                //        Console.WriteLine($"{movie} was removed");
                //    }
                //    else
                //    {
                //         Console.WriteLine("Sorry there was no movies with that name");
                //         validOption = false;
                //        return;

                //    }
                //}

            } while (validOption == false);

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
}
