using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class VotingTests
    {
        [Fact]
        public void Test_VotingId()
        {
            var expected = typeof(Guid);
            var sut = new Voting();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }


        //voting need to have ppl and list of vote?

        //voting needs to have one movie
        [Fact]
        public void Test_VotingMovie()
        {
            //var expected = 1;
            //var sut = new Movie();
            var sut = new Voting();
            Assert.NotNull(sut.Movie);
            //var actual = sut.Vote;

            //Assert.True(expected <= actual.Count);
        }
        

        //need to have at least one person?
        [Fact]
        public void Test_VotingPeople()
        {
            var expected = 0; //was 1?? do all movies get 1 vote to begin with?
            var sut = new Voting();
            var actual = sut.People;

            Assert.True(typeof(List<Person>) == actual.GetType());
            Assert.True(expected <= actual.Count);

        }
        //vote needs to hold who voted and who they voted for 
    }
}
