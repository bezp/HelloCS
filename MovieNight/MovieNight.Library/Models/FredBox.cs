using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class FredBox
    {
        private List<Movie> Movies
        {
            get;
            set;
        }

        public FredBox()
        {
            Movies = new List<Movie>();
        }

        public Movie MakeMovie(string title)
        {

            return new Movie()
            {
                Title = title
            };
        }

        public IEnumerable<Movie> GetMovies()
        {
            //return new List<Movie>()
            return Movies;
        }

        public void DistributeMovie(Movie movie)
        {
            Movies.Add(movie);
        }
    }
}
