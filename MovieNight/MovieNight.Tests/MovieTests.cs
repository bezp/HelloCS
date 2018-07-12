using MovieNight.Library.Enums;
using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class MovieTests
    {
        //Movie movie = new Movie(); //this will work but there is an issue --we will 
        //create an object everytime a test is run (test will use more memory than
        //we want)
        //we want movie to be ready during runtime
        //when do we want to have movie ready? right before u are going to use it
        //fix below \/
        private Movie sut; //default is private
        public MovieTests() //two most important members of a class are CONSTRUCTORS/DECONSTRUCTORS
        {
            sut = new Movie();
        }

        [Fact]
        public void Test_MovieId()
        {
            var expected = typeof(Guid);
            //var sut = new Movie();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
            //Assert.True(actual.GetType() == expected);
        }


        //list is an enumerable; collection = enumerables (things u can count)
        [Fact]
        public void Test_MovieActors()
        {
            var expected = 1;
            //var sut = new Movie();
            var actual = sut.Actors;

            Assert.True(typeof(List<Actor>) == actual.GetType());
            Assert.True(expected <= actual.Count);
        }



        [Fact]
        public void Test_MovieTitle()
        {
            var expected = typeof(string);
            Assert.True(expected == sut.Title.GetType());

            //after lunch
            Assert.NotEmpty(sut.Title);
        }

        [Fact]
        public void Test_MovieGenre()
        {
            var expected = typeof(EGenre);
            Assert.True(expected == sut.Genre.GetType());
            Assert.NotNull(sut.Genre);
        }


    }
}
