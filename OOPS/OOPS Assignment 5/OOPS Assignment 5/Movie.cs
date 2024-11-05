using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment_5
{
    public class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public Movie(string title, int year)
        {
            Title = title;
            Year = year;
        }

    }
    public class MovieLibrary
    {
        public Movie[] movies;
        public MovieLibrary()
        {
            movies = new Movie[]
            {
                new Movie("Vikram",2021),
                new Movie("The pricess diaries",2002),
                new Movie("Notebook",2010)
            };
        }
        public void Display()
        {
            Console.WriteLine("The movies in the library");
            foreach (var movie in movies)
            {
                Console.WriteLine(movie.Title + " , " + movie.Year );
            }
        }
    }
}
