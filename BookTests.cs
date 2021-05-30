using System;
using System.Collections.Generic;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesStatistics()
        {
            // arrange
            var book = new InMemoryBook(name: "Test Book", grades: new List<double>() { 12.34, 45.62, 32.60, 23.43 });

            // act
            double lowestGrade = book.GetStatistics().Low;
            double highestGrade = book.GetStatistics().High;
            double averageGrade = book.GetStatistics().Average;

            // assess
            Assert.Equal(12.33, lowestGrade, 1);
            Assert.Equal(45.61, highestGrade, 1);
            Assert.Equal(28.5, averageGrade, 1);

        }
    }
}
