using System;
using System.Collections.Generic;
using System.Text;

using Xunit;
using TriangleSort;
namespace TriangleSortTests
{
    public class TriangleParserTest
    {
        [Theory]
        [InlineData("first 4, 4")]
        [InlineData("second 444 4.9, 4")]
        [InlineData("")]
        public void TryParseTest_ThrowExeption(string args)
        {
            //arrange
            FigureParser figureParser = new TriangleParser(args);

            //assert
            Assert.Throws<ArgumentException>(()
                => figureParser.TryParse());
        }

        [Theory]
        [InlineData("first 4, 4, 4")]
        [InlineData("second 49, 46, 47")]        
        public void TryParseTest(string args)
        {
            //arrange
            FigureParser figureParser = new TriangleParser(args);
            IFigureFactory expected = figureParser.TryParse();

            //act
            IFigureFactory actual = figureParser.TryParse();

            //assert
            Assert.True(expected.Equals(actual));
        }


        [Fact]
        public void GetNameTest_ThrowArgumentExpeption()
        {
            //arrange
            FigureParser figureParser = new TriangleParser("");

            //assert
            Assert.Throws<ArgumentException>(()
                => figureParser.TryParse());

        }

        [Theory]
        [InlineData("second, -4 4, 4")]
        [InlineData("second, 4 0, 4")]
        public void GetNameTest_ThrowArgumentOutOfRangeExp(string args)
        {
            //arrange
            FigureParser figureParser = new TriangleParser(args);

            //assert
            Assert.Throws<ArgumentOutOfRangeException>(()
                => figureParser.TryParse());
        }

        //[Theory]
        //[InlineData("first 4, 4, 4", "first")]
        //[InlineData("second, 4 4, 4", "second")]
        //public void GetNameTest(string args, string expected)
        //{
        //    //arrange
        //    FigureParser figureParser = new TriangleParser(args);

        //    //assert
        //    string actual = figureParser.GetName();

        //    //assert
        //    Assert.Equal(expected, actual);
        //}

        //[Theory]
        //[InlineData("first 4, 4, 4", new double[] { 4, 4, 4 })]
        //[InlineData("second, 54 4.9, 4", new double[] { 54, 4.9, 4 })]
        //public void GetSidesTest(string args, double[] expected)
        //{
        //    //arrange
        //    FigureParser figureParser = new TriangleParser(args);

        //    //assert
        //    double[] actual = figureParser.GetSides();

        //    //assert
        //    Assert.Equal(expected, actual);
        //}

        [Theory]
        [InlineData("first 4, j4, 4")]
        [InlineData("second, 54 4.9, dtrt")]
        public void GetSidesTest_ThrowExeption(string args)
        {
            //arrange
            FigureParser figureParser = new TriangleParser(args);

            //assert
            Assert.Throws<FormatException>(()
                => figureParser.TryParse());
        }
    }
}
