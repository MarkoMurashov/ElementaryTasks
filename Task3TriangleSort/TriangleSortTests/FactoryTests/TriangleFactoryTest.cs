using System;
using System.Collections.Generic;
using System.Text;

using Xunit;
using Moq;
using TriangleSort;

namespace TriangleSortTests
{
    public class TriangleFactoryTest
    {
        [Fact]
        public void CreateTest()
        {
            //arrange
            var mockFigure = new Mock<IFigure>();
            mockFigure.Setup(a => a.Area).Returns(0);
            mockFigure.Setup(a => a.Name).Returns("default");

            IFigure expected = mockFigure.Object;
                       
            var mockFactory = new Mock<IFigureFactory>();
            mockFactory.Setup(m => m.Create()).Returns(mockFigure.Object);

            //act
            IFigureFactory factory = mockFactory.Object;
            var actual = factory.Create();

            //assert
            Assert.True(expected.Name == actual.Name && expected.Area == actual.Area);
        }
      
    }
}
