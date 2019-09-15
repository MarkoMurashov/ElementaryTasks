using System;
using System.Collections.Generic;
using System.Text;

using Xunit;
using Moq;
using TriangleSort;
namespace TriangleSortTests
{
    public class TriangleParserTest
    {
        [Theory]
        [InlineData("first 4, 4")]
        [InlineData("second 444 4.9, 4 9 9")]
        [InlineData("")]
        public void TryParse_ShouldThrowArgumentExeption_When_WrongArgumentNumber(string args)
        {
            //arrange
            var triangleParser = new TriangleParser(args);
                     
            //assert
            Assert.Throws<ArgumentException>(()
                => triangleParser.TryParse());
        }

        [Theory]
        [InlineData("first 4, 4, 4")]
        [InlineData("second 49, 46, 47")]        
        public void TryParse_WithTriangleDate_ShouldReturnIFigureFactory(string args)
        {

            var parser = new TriangleParser(args);

            //assert
            Assert.IsAssignableFrom<IFigureFactory>(parser.TryParse());
        }
       
    }
}
