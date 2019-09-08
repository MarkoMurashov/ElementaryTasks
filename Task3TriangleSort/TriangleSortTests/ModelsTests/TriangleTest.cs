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

        [Theory]
        [InlineData(4, 4, 4, true)]
        [InlineData(4.6, 8.9, 11 , true)]
        [InlineData( 444, 4, 4 , false)]
        public void IsTriangleExistTest(double first, double second, double third, bool expected)
        { 
            //act
            bool actual = Triangle.IsTriangleExist(first, second, third);

            //assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("first", new double[] { 4, 4, 4 }, "first", new double[] { 4, 4, 4 }, true)]
        [InlineData("second", new double[] { 4.6, 8.9, 11 }, "second", new double[] { 4.6, 8.9, 45 }, false)]
        [InlineData("second", new double[] { 4.6, 8.9, 11 }, "sadadadasdasda", new double[] { 4.6, 8.9, 11 }, false)]
        public void EqualsTest(string name, double[] sides, string name2, double[] sides2, bool expected)
        {
            //arrange
            IFigure triangle = new Triangle(name, sides);
            IFigure triangle2 = new Triangle(name2, sides2);

            //act
            bool actual = triangle.Equals(triangle2);

            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("first", new double[] { 4, 4, 4 }, "first", new double[] { 4, 4, 4 })]
        public void EqualsTest_ThrowExp(string name, double[] sides, string name2, double[] sides2)
        {
            //arrange
            IFigureFactory factory = new TriangleFactory(name, sides);
            IFigure figure = new Triangle(name2, sides2);

            //assert
            Assert.Throws<InvalidCastException>(()
                => figure.Equals(factory));
        }

    }
}
