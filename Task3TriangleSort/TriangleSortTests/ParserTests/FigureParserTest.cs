using System;
using System.Collections.Generic;
using System.Reflection;

using Xunit;
using Moq;
using TriangleSort;

namespace TriangleSortTests
{

    public class FigureParserTest
    {


        [Theory]
        [InlineData("first 4, 4, 4", "first")]
        [InlineData("second, 4 4, 4", "second")]
        public void GetNameTest(string args, string expected)
        {
            //arrange
            var mockFigureParser = new Mock<FigureParser>(MockBehavior.Default, args);
            mockFigureParser.Setup(a => a.GetName()).Returns(expected);

            //act
            var actual = mockFigureParser.Object;

            //assert
            Assert.True(expected == actual.GetName());            
        }

        [Theory]
        [InlineData("first 4, 4, 4", new double[] { 4, 4, 4 })]
        [InlineData("second, 54 4.9, 4", new double[] { 54, 4.9, 4 })]
        public void GetSidesTest(string args, double[] expected)
        {
            //arrange
            var mockFigureParser = new Mock<FigureParser>(MockBehavior.Default, args);
            mockFigureParser.Setup(a => a.GetSides()).Returns(expected);

            //act
            var actual = mockFigureParser.Object;

            //assert
            Assert.Equal(expected, actual.GetSides());
        }

        [Fact]
        public void GetNameTest_ThrowArgumentExpeption()
        {
            //arrange
            var mockFigureParser = new Mock<FigureParser>(MockBehavior.Default, string.Empty);
            mockFigureParser.Setup(a => a.GetName()).Throws(new ArgumentException());

            //act
            var actual = mockFigureParser.Object;

            //assert
            Assert.Throws<ArgumentException>(()
                => actual.GetName());

        }

        [Theory]
        [InlineData("second, -4 4, 4")]
        [InlineData("second, 4 0, 4")]
        public void GetSidesTest_ThrowArgumentOutOfRangeExp(string args)
        {
            //arrange
            var mockFigureParser = new Mock<FigureParser>(MockBehavior.Default, args);
            mockFigureParser.Setup(a => a.GetSides()).Throws(new ArgumentOutOfRangeException());

            //act
            var actual = mockFigureParser.Object;

            //assert
            Assert.Throws<ArgumentOutOfRangeException>(()
                => actual.GetSides());
        }

        [Theory]
        [InlineData("first 4, j4, 4")]
        [InlineData("second, 54 4.9, dtrt")]
        public void GetSidesTest_ThrowExeption(string args)
        {
            //arrange
            var mockFigureParser = new Mock<FigureParser>(MockBehavior.Default, args);
            mockFigureParser.Setup(a => a.GetSides()).Throws(new FormatException());

            //act
            var actual = mockFigureParser.Object;

            //assert
            Assert.Throws<FormatException>(()
                => actual.GetSides());
        }

    }
}
