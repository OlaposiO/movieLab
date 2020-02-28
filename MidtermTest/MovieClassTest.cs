using System;
using Xunit;
using Midterm;

namespace MidtermTest
{
    public class MovieClassTest
    {
        [Fact]
        public void MovieClassListTest()
        {
            //Assemble
            Movie movie = new Movie();
            movie.MovieName = "John Wick";
            movie.MainActor = "Keanu Reeves";
            movie.Genre = "Action";
            movie.Director = "Olaposi Omishope";

            string expected = $"John Wick, Keanu Reeves, Action, Olaposi Omishope";

            //Action
            string actual = movie.MovieString;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
