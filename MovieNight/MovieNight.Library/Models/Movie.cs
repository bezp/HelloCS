using MovieNight.Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class Movie : AModel
    {
        public Movie()
        {
            Actors = new List<Actor>()
            {
                new Actor()
            };

        }

        public List<Actor> Actors
        {
            get;
            set;
        }

    }
}
