using System;
using System.Collections.Generic;
using System.Reflection;

using Xunit;
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

            ////arrange
            FigureParser figureParser = new TriangleParser(args);

            ////act
            string actual = figureParser.GetName();

            ////assert
            Assert.True(expected == actual);            
        }

        [Theory]
        [InlineData("first 4, 4, 4", new double[] { 4, 4, 4 })]
        [InlineData("second, 54 4.9, 4", new double[] { 54, 4.9, 4 })]
        public void GetSidesTest(string args, double[] expected)
        {
            //arrange
            FigureParser figureParser = new TriangleParser(args);

            //assert
            double[] actual = figureParser.GetSides();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetNameTest_ThrowArgumentExpeption()
        {
            //arrange
            FigureParser figureParser = new TriangleParser("");

            //assert
            Assert.Throws<ArgumentException>(()
                => figureParser.GetName());

        }

        [Theory]
        [InlineData("second, -4 4, 4")]
        [InlineData("second, 4 0, 4")]
        public void GetSidesTest_ThrowArgumentOutOfRangeExp(string args)
        {
            //arrange
            FigureParser figureParser = new TriangleParser(args);

            //assert
            Assert.Throws<ArgumentOutOfRangeException>(()
                => figureParser.GetSides());
        }

        [Theory]
        [InlineData("first 4, j4, 4")]
        [InlineData("second, 54 4.9, dtrt")]
        public void GetSidesTest_ThrowExeption(string args)
        {
            //arrange
            FigureParser figureParser = new TriangleParser(args);

            //assert
            Assert.Throws<FormatException>(()
                => figureParser.GetSides());
        }

    }
}
