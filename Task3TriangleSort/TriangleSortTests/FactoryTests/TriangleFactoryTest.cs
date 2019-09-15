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
        [Theory]
        [InlineData("lala", new double[] { 6, 3, 4 })]
        [InlineData("alal", new double[] { 5, 4, 6 })]
        public void Create_ShouldReturnIFigure(string name, double[] sides)
        {
            var factory = new TriangleFactory(name, sides[0], sides[1], sides[2]);
            
            //assert
            Assert.IsAssignableFrom<IFigure>(factory.Create());
        }
      
    }
}
