using System;
using Xunit;
using src;

namespace test
{
    public class GradeBookTest
    {
        [Fact]
        public void BookCalculatesAverageGrade()
        {
            //arrange
            var book =new Book(""); //need to add reference of this  
            book.AddGrade(1.2);
            book.AddGrade(2.4);
            book.AddGrade(4.6);

            //act
            var result=book.GetStatistics();

            //assert 
            Assert.Equal(8.2,result.SUM, 1);
            Assert.Equal(2.7,result.Avg, 1);
            Assert.Equal(4.6,result.High,1);
            Assert.Equal(1.2,result.Low, 1);     
            Assert.Equal('D',result.Letter);       

        }
    }
}
