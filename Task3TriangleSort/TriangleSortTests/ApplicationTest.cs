using System;
using System.Collections.Generic;
using System.Text;

using Xunit;
using TriangleSort;
using ViewController;
using System.Linq;

namespace TriangleSortTests
{
    public class ApplicationTest
    {

        [Fact]
        public void SquareTest()
        {
            //arrange
            List<IFigure> figures = new List<IFigure>();
            Triangle t1 = new Triangle("first", new double[] { 4, 4, 4 });
            figures.Add(t1);
            Triangle t2 = new Triangle("second", new double[] { 14, 14, 16 });
            figures.Add(t2);
            Triangle t3 = new Triangle("third", new double[] { 14, 14, 18});
            figures.Add(t3);
            Triangle t4 = new Triangle("fourth", new double[] { 1, 2, 2 });
            figures.Add(t4);

            List<IFigure> figures2 = new List<IFigure>();
            figures2.Add(t4);
            figures2.Add(t1);
            figures2.Add(t2);
            figures2.Add(t3);

            string expected = string.Join("", figures2);

            //act
            Application app = new Application(new ConsoleUI());
            var query = app.SortBySquare(figures);
            string actual = string.Join("", query);

            //assert
            Assert.True(expected == actual);
        }
    }
}
