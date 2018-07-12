using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class MovieTests
    {
        [Fact]
        public void Test_MovieId()
        {
            var expected = typeof(Guid);
            var sut = new Movie();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
            //Assert.True(actual.GetType() == expected);
        }


        //list is an enumerable; collection = enumerables (things u can count)
        [Fact]
        public void Test_MovieActors()
        {
            var expected = 1;
            var sut = new Movie();
            var actual = sut.Actors;

            Assert.True(typeof(List<Actor>) == actual.GetType());
            Assert.True(expected <= actual.Count);
        }
        //[Fact]
        //public void Test_Movie()
        //{
        //    var expected = 1;
        //    var sut = new Movie();
        //    var actual = sut.Actor;

        //    Assert.True(expected <= actual.Count);
        //}
    }
}
