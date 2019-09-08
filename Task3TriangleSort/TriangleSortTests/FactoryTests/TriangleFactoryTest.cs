using System;
using System.Collections.Generic;
using System.Text;

using Xunit;
using TriangleSort;

namespace TriangleSortTests
{
    public class TriangleFactoryTest
    {
        [Theory]
        [InlineData("first", new double[] { 4, 4, 4 })]
        [InlineData("second", new double[] { 4.6, 8.9, 11 })]
        public void CreateTest(string args, double[] sides)
        {
            //arrange
            IFigureFactory factory = new TriangleFactory(args,sides);
            IFigure expected = new Triangle(args, sides);
            
            //act
            IFigure actual = factory.Create();

            //assert
            Assert.True(expected.Equals(actual));
        }

        [Fact]
        public void CreateTest_ThrowExp()
        {
            //arrange
            IFigureFactory factory = new TriangleFactory("", null);

            //assert
            Assert.Throws<InvalidCastException>(()
                =>  factory.Create()); 
        }

        [Theory]
        [InlineData("first", new double[] { 4, 4, 4 }, "first", new double[] { 4, 4, 4 }, true )]
        [InlineData("second", new double[] { 4.6, 8.9, 11 }, "second", new double[] { 4.6, 8.9, 45 }, false)]
        [InlineData("second", new double[] { 4.6, 8.9, 11 }, "sadadadasdasda", new double[] { 4.6, 8.9, 11 }, false)]
        public void EqualsTest(string name, double[] sides, string name2, double[] sides2, bool expected)
        {
            //arrange
            IFigureFactory factory = new TriangleFactory(name, sides);
            IFigureFactory factory2 = new TriangleFactory(name2, sides2);

            //act
            bool actual = factory.Equals(factory2);

            //assert
            Assert.Equal(expected,actual);
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
                => factory.Equals(figure));
        }
    }
}
