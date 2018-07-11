using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MovieNight.Library.Models;

namespace MovieNight.Tests
{
    public class HistoryTests
    {
        [Fact]
        public void Test_HistoryId()
        {
            var expected = typeof(Guid);
            var sut = new History();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
            //Assert.True(actual.GetType() == expected);
        }

        [Fact]
        public void Test_HistoryMovies()
        {
            var expected = 1;
            //subject under test
            var sut = new History(); //want it to giv u the list of movies youve seen
            var actual = sut.Movies;

            Assert.True(typeof(List<Movie>) == actual.GetType()); //needs to be a list
            Assert.True(expected <= actual.Count);
        }


    }
}
