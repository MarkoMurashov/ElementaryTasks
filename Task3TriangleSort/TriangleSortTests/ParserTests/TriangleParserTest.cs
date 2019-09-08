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
       
    }
}
