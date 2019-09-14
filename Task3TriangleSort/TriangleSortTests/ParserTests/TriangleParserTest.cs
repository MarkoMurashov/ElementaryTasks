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
        [InlineData("second 444 4.9, 4")]
        [InlineData("")]
        public void TryParseTest_ThrowExeption(string args)
        {
            //arrange
            var triangleParser = new TriangleParser(args);
                     
            //assert
            Assert.Throws<ArgumentException>(()
                => triangleParser.TryParse());
        }

        [Theory]
        [InlineData("first 4, 4, 4", "first", new double[] { 4, 4, 4 })]
        [InlineData("second 49, 46, 47", "second", new double[] { 49, 46, 47 })]        
        public void TryParseTest(string args, string expectedName, double[] expectedSides)
        {

            var mockFactory = new Mock<TriangleFactory>(MockBehavior.Default,
                expectedName, expectedSides[0], expectedSides[1], expectedSides[2]);
            var triangleFactory = mockFactory.Object;
            
            var mockFigureParser = new Mock<TriangleParser>(MockBehavior.Default, args);
            mockFigureParser.Setup(a => a.TryParse()).Returns(triangleFactory);
          
            //assert
            Assert.True(triangleFactory == mockFigureParser.Object.TryParse());
        }
       
    }
}
