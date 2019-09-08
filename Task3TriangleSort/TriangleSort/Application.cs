using System;
using System.Collections.Generic;
using System.Linq;

using ViewController;

namespace TriangleSort
{
    public class Application
    {
        private IView View { get; set; }

        public Application(IView view)
        {
            View = view;
        }

        public void Run()
        {                     
            List<IFigure> myTriangles = new List<IFigure>();

            do
            {
                string args = View.GetStringData(Settings.INVITATION);
                try
                {
                    IFigureFactory factory = new TriangleParser(args).TryParse();
                    myTriangles.Add(factory.Create());
                }
                catch(FormatException ex)
                {
                    View.Display(ex.Message);
                }
                catch (ArgumentException ex)
                {
                    View.Display(ex.Message);
                }

            } while (View.ContinueWork(Settings.CONTINUATION_STRING));

            var sortedTriangles = SortBySquare(myTriangles);

            if (sortedTriangles.Count() != 0)
            {
                View.Display(Settings.TITLE);
                foreach (var k in sortedTriangles)
                {
                    View.Display(k.ToString());
                }
            }
            else
            {                
                View.Display(Settings.NO_ELEMENTS);
            }

            View.Saybye();
        }

        public IOrderedEnumerable<IFigure> SortBySquare(IEnumerable<IFigure> myTriangles)
        {
            var sortedTriangles = from triangle in myTriangles
                                  orderby triangle.Square
                                  select triangle;

            return sortedTriangles;           
        }
    }
}
