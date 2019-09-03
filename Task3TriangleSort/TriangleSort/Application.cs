using System;
using System.Collections.Generic;

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
            SortedSet<Triangle> myTriangles = new SortedSet<Triangle>(new SortTrianglesBySquare());

            do
            {
                string args = View.GetStringData(Settings.INVITATION);
                try
                {
                    myTriangles.Add(TriangleFactory.Create(Validation, args));
                }
                catch(Exception ex)
                {
                    View.DisplayError(ex);
                }
                
            } while (View.ContinueWork(Settings.CONTINUATION_STRING));

            View.Display(Settings.TITLE);

            foreach (var k in myTriangles)
            {
                View.Display(k.ToString());
            }

            View.Saybye();
        }
    }
}
