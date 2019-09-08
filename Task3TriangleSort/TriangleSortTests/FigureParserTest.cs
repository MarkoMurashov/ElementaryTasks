using System;
using System.Collections.Generic;
using System.Reflection;

using Xunit;
using TriangleSort;

namespace TriangleSortTests
{
    public class FigureParserTest : FigureParser
    {

        public FigureParserTest(string args)
            :base(args)
        {

        }

        [Theory]
        [InlineData("first 4, 4, 4", "first")]
        [InlineData("second, 4 4, 4", "second")]
        public void GetNameTest(string args, string expected)
        {
            //arrange
            FigureParserTest figure = new FigureParserTest("first 4, 4, 4");

            //act
            string actual = figure.GetName();           

            //assert
            Assert.True(expected == actual);
        }

        [Theory]
        [InlineData("first 4, 4, 4", new double[] { 4, 4, 4 })]
        [InlineData("second, 54 4.9, 4", new double[] { 54, 4.9, 4 })]
        public void GetSidesTest(string args, double[] expected)
        {
            ////arrange
            //FigureParser figureParser = new TriangleParser(args);

            ////assert
            //double[] actual = figureParser.GetSides();

            ////assert
            //Assert.Equal(expected, actual);
        }

        public override IFigureFactory TryParse() { return null; }
    }
}
