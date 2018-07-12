using MovieNight.Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class Voting : AModel
    {
        public Movie Movie
        {
            get;
            set;
        }

        public List<Person> People
        {
            get;
            set;
        }

        public Voting()
        {
            Movie = new Movie();

            People = new List<Person>
            {
                new Person()
            };
        }
    }
}
