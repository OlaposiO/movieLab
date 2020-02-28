using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    class OlliesMovieApp
    {
        public SearchForMovie search { get; set; }
        public List<Movie> movieList { get; set; }
        public List<Movie> moviesResults { get; set; }
        public bool appRunning { get; set; }

        public void StartApp()
        {

            search = new SearchForMovie();
            movieList = SaveLoad.Load();
            SaveLoad.Save(movieList);
            moviesResults = new List<Movie>();
            appRunning = false;

            do
            {
                
                SaveLoad.Save(movieList);
                movieList = SaveLoad.Load();
                MenuOptions choice = MovieLover.GetMenuOption();
                ExecuteMainMenuChoice(choice, movieList);
            } while (appRunning);
        }

        public void ExecuteMainMenuChoice(MenuOptions choice, List<Movie> movieList)
        {
            moviesResults = new List<Movie>();
            switch (choice)
            {
                case MenuOptions.DisplayAll:
                    Console.Clear();
                    Menu.DisplayAllMovies(movieList);
                    moviesResults = movieList;
                    appRunning = true;
                    return;
               
                case MenuOptions.SearchByMovieName:
                    Console.Clear();
                    moviesResults = MovieLover.MovieLoverSeachMovieName(movieList);
                    appRunning = true;
                    return;

                case MenuOptions.SearchByMainActor:
                    Console.Clear();
                    moviesResults = MovieLover.MovieLoverSeachMainActor(movieList);
                    appRunning = true;
                    return;


                case MenuOptions.SearchByGenre:
                    Console.Clear();
                    moviesResults = MovieLover.MovieLoverSeachGenre(movieList);
                    appRunning = true;
                    return;

                case MenuOptions.SeachByDirector:
                    Console.Clear();
                    moviesResults = MovieLover.MovieLoverSearchDirector(movieList);
                    appRunning = true;
                    return;

                case MenuOptions.ManageMovies:
                    Console.Clear();
                    AddAndRemoveMovie.ManageMovie(movieList);
                    appRunning = true;
                    SaveLoad.Save(movieList);
                    return;


                case MenuOptions.Quit:
                    appRunning = false;
                    SaveLoad.Save(movieList);
                    return;

                default: return;
            }

        }


    }
}
