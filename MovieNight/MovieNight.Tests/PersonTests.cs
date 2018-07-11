using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class PersonTests
    {
        [Fact]
        public void Test_PersonId()
        {
            var expected = typeof(Guid);
            var sut = new Person();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }

        //how many movies have they seen, so we need to test history 
        [Fact]
        public void Test_PersonHistory()
        {
            //if we want to test that something just exists, we can skip some steps
            //var sut = new Person();
            //Assert.NotNull(sut.History);

            Assert.NotNull(new Person().History);
        }
    }
}
