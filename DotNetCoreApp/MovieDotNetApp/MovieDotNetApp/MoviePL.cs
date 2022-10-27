using System;
using System.Collections.Generic;
using System.Text;
using MovieEntity.BookMyShow;
using MovieEntity.Models;

namespace MovieDotNetApp
{
    public class MoviePL
    {
        public void AddMovie()
        {
            MovieOperations movieOperations = new MovieOperations();
            Movie movie = new Movie();
            Console.WriteLine("Enter MovieName : ");
            movie.Name = Console.ReadLine();
            Console.WriteLine("Enter Movie Description : ");
            movie.MovieDesc = Console.ReadLine();
            Console.WriteLine("Enter Movie Type : ");
            movie.MovieType = Console.ReadLine();
            string msg = movieOperations.AddMovie(movie);
            Console.WriteLine(msg);
        }
        public void ShowAllMovie()
        {
            MovieOperations movieOperations = new MovieOperations();
            List<Movie> movies = movieOperations.ShowAll();
            foreach(var item in movies)
            {
                Console.WriteLine("Id : "+item.Id);
                Console.WriteLine("Name : " + item.Name);
                Console.WriteLine("Description : " + item.MovieDesc);
                Console.WriteLine("Type : " + item.MovieType);
            }
        }
    }
}
