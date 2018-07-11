using MovieNight.Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class History : AModel
    {
        public List<Movie> Movies //doesnt say that it is a list, ONLY that it can hold a list 
            //its not a container, just says it can be a container 
        {
            get;
            set;
        }

        public History()
        {
            //Movies = new List<Movie>(); // THIS will be the container for the property up there
            //Movies.Add(new Movie()); //whenever a history object is created, add it to the list
            Movies = new List<Movie>() //creates a new list and adds something to it; we dont want a private 
                                        // field cause then everyone would have a list???
            {
                new Movie()
            };
        }
    }
}
