using Lab7Collections;
using System;
using Xunit;
using static Lab7Collections.Program;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void AddABook()
        {
            Book Contagious = new Book("Contagious: Why things catch on", new Author("Jonah", "Berger"), Genre.Self, 256);
            Assert.Equal("Contagious: Why things catch on", Contagious.Title);
        }

    



    }
}
