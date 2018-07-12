using MovieNight.Library.Abstracts;
using MovieNight.Library.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class Movie : AModel
    {
        public string Title
        {
            get;
            set;
        }

        public EGenre Genre
        {
            get;
            set;
        }

        public List<Actor> Actors
        {
            get;
            set;
        }

        public Movie()
        {
            Actors = new List<Actor>()
            {
                new Actor()
            };
            Title = string.Empty; // w/o this the Test_MovieTitle sut will be null
        }
    }
}
