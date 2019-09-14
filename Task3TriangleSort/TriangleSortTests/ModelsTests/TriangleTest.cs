using System;
using System.Collections.Generic;
using System.Text;

using Xunit;
using TriangleSort;

namespace TriangleSortTests
{
      
    public class TriangleTest
    {

        [Theory]
        [InlineData(new double[] {4, 4, 4}, 6.9)]
        [InlineData(new double[] { 4.6, 8.9, 11 }, 19.8)]
        [InlineData(new double[] { 8, 10, 4 }, 15.2)]
        public void test_Area_withThreeTriangleSides_ReturnExpectedArea(double[] sides,  double expected)
        {
            //arrange
            const string triangleName = "default";            
            var triangle = new Triangle(triangleName, sides[0], sides[1], sides[2]);
            
            //act
            double actual = triangle.Area;
           
            //assert
            Assert.Equal(expected, actual, 1);              
        }

        [Theory]
        [InlineData(4, 4, 4, true)]
        [InlineData(4.6, 8.9, 11 , true)]
        [InlineData( 444, 4, 4 , false)]
        public void Should_ReturnTrue_When_TriangleExist(double first, double second, double third, bool expected)
        { 
            //arrange and act
            bool actual = Triangle.IsTriangleExist(first, second, third);

            //assert
            Assert.Equal(expected, actual);
        }     

    }
}
