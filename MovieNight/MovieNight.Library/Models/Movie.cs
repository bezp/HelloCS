using MovieNight.Library.Abstracts;
using MovieNight.Library.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class Movie : AModel
    {
        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    return;
                }

                _title = value;
            }
        }

        public Movie()
        {
            Initialize();
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

        //private Movie() //public ->private during refactor so u need to movies a differenct way
        //{
        //    Actors = new List<Actor>()
        //    {
        //        new Actor()
        //    };
        //    Title = "(no title)"; // w/o this the Test_MovieTitle sut will be null
        //    Genre = EGenre.Romantic_Western;
        //} //not needed b/c of the newer public Movie constructors (3) and Initialize

        public Movie(string title)
        {
            Initialize(title);
        }

        public Movie(string title, EGenre genre)
        {
            Initialize(genre: genre, title: title); //named parameters (not by position)
        }

        public Movie(string title, EGenre genre, List<Actor> actors)
        {
            Initialize(title, genre, actors);
        }


        public void Initialize(string title = "(no title)", EGenre genre = EGenre.None, List<Actor> actors = null)
        {
            Title = title;
            Genre = genre;
            Actors = actors ?? new List<Actor>{ new Actor() }; //new List<Actor>()
        }
    }
}
