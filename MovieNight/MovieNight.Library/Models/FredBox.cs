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
        //public FredBox(List<Movie> movie)
        //{

        //}
        //public void Initialize(List<Movie> movie)
        //{
        //    Movies = movie;
        //}

        public Movie MakeMovie(string title)
        {
            Movie movie = new Movie();

            try
            {
                if (string.IsNullOrWhiteSpace(title))
                {
                    throw new ArgumentNullException(title, "title cannot be null or whitespaced");
                }
                else
                {
                    movie = new Movie()
                    {
                        Title = title
                    };
                }
            }
            catch (ArgumentNullException ex)//if we get title = null
            {
                //throw;
                MakeMovie("not available"); //swallowing the error 
            }
            catch (ArgumentException ex)
            {
                throw new Exception("not sure how it happened", ex);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                //movie = new Movie(title);
                GC.Collect();
            }
            return movie;
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
