using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void ShouldCalculateStatistics()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(1.0);
            book.AddGrade(0.0);
            book.AddGrade(30);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(10.3, result.AverageGrade, 1);
            Assert.Equal(0.0, result.LowestGrade, 1);
            Assert.Equal(30, result.HighestGrade, 1);
        }
    }
}
