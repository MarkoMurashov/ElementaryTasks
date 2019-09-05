using System;
using System.Collections.Generic;
using System.Linq;

using ViewController;
using ConsoleArgsValidation;

namespace TriangleSort
{
    class Application
    {
        private IValid Validation { get; set; }

        private IView View { get; set; }

        public Application(IValid valid, IView view)
        {
            Validation = valid;
            View = view;
        }

        public void Run()
        {
                      
            List<Triangle> myTriangles = new List<Triangle>();

            do
            {
                string args = View.GetStringData(Settings.INVITATION);
                try
                {
                    myTriangles.Add(Triangle.Create(Validation, args));
                }
                catch(Exception ex)
                {
                    View.DisplayError(ex);
                }
                
            } while (View.ContinueWork(Settings.CONTINUATION_STRING));

            View.Display(Settings.TITLE);

            var sortedTriangles = from triangle in myTriangles
                                  orderby triangle.Square
                                  select triangle;

            foreach (var k in sortedTriangles)
            {
                View.Display(k.ToString());
            }

            View.Saybye();
        }
    }
}
