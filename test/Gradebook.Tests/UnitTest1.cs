using System;
using Xunit;

namespace Gradebook.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var book = new Book("Test");
            book.AddGrades(23.11);
            book.AddGrades(25.11);
            book.AddGrades(23.12);

            //Act
            var result = book.GetStats();
            
            //Assert
            Assert.Equal(23.8,result.Average,1);
            Assert.Equal(25.11,result.High,1);
            Assert.Equal(23.11,result.Low,1);
        }
    }
}
