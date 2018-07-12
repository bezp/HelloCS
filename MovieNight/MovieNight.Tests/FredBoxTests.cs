using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MovieNight.Library.Models;
using System.Linq;

namespace MovieNight.Tests
{
    public class FredBoxTests
    {
        private FredBox sut;
        public FredBoxTests()
        {
            
            sut = new FredBox();
        }

        [Fact]
        public void Test_FredBoxMakeMovie()
        {
            var expected = "My First Movie";
            var actual = sut.MakeMovie(expected);

            Assert.True(expected == actual.Title);
        }

        [Fact]
        public void Test_FredBoxGetMovies()
        {
            var expected = 0;
            var actual = sut.GetMovies();

            Assert.True(expected <= actual.Count()); //calling the count() method b/c its a IEnum; not a list
        }

        [Fact]
        public void Test_FredBoxDistributeMovie()
        {
            
            var title = "My Second Movie";
            //sut.DistributeMovie(sut.MakeMovie("My Second Movie"));
            var expected = sut.GetMovies().Count(); //see what movies i currently have
            //Movie actual;

            sut.DistributeMovie(sut.MakeMovie(title));
            //DistruibuteMovie should put MakeMovie put stuff into GetMovies
            //var actuak = sut.GetMovies();  just put it in next line w/o actuak

            //Assert.True(expected.Count() < sut.GetMovies().Count()); //expected is a reference
            Assert.True(expected < sut.GetMovies().Count()); //expected is an actual value
            //what are we trying to do? 
        }



    }
}
