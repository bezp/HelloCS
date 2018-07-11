﻿using MovieNight.Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class Movie : AModel
    {
        public List<Person> Actors
        {
            get;
            set;
        }
        public Movie()
        {
            Actors = new List<Person>()
            {
                new Person()
            };

        }
    }
}
