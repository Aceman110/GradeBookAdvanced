using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // arrange section - This where you put together all your test data
            // and you arrange the objects and the values that you are going to use
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);
            // act section - This is where you invoke a method to perform a 
            // computation or perform a calculation
            var result = book.GetStatistics();
            //assert section - This is where you assert something about the
            //value generated in the act section
            Assert.Equal(85.6, result.Average, 1);     
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
        }
    }
}