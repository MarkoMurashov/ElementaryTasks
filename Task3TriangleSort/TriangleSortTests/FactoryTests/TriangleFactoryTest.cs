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
            IFigure expected = mockFigure.Object;
                       
            var mockFactory = new Mock<IFigureFactory>();
            mockFactory.Setup(m => m.Create()).Returns(expected);

            //act
            IFigureFactory factory = mockFactory.Object;

            //assert
            Assert.True(expected == factory.Create());
        }
      
    }
}
