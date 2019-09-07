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
        [InlineData("first", new double[] {4, 4, 4}, 6.9)]
        [InlineData("second", new double[] { 4.6, 8.9, 11 }, 19.8)]
        [InlineData("third", new double[] { 8, 10, 4 }, 15.2)]
        public void SquareTest(string name, double[] sides,  double expected)
        {
            //arrange
            Triangle triangle = new Triangle(name, sides);

            //act
            double actual = triangle.Square;
           
            //assert
            Assert.Equal(expected, actual, 1);              
        }

    }
}
