﻿using System;
using System.Collections.Generic;
using System.Linq;

using NLog;
using ViewController;

namespace TriangleSort
{
    public class Application
    {
        #region Properties

        private IView View { get; set; }

        private ILogger Logger { get; set; }

        #endregion

        #region Ctor

        public Application(IView view, ILogger logger)
        {
            View = view;
            Logger = logger;
        }

        #endregion

        public void Run()
        {
            Logger.Info(Settings.APP_START);

            var myTriangles = new List<IFigure>();

            do
            {
                string args = View.GetStringData(Settings.INVITATION);

                try
                {
                    var factory = new TriangleParser(args).TryParse();
                    myTriangles.Add(factory.Create());
                }
                catch (FormatException ex)
                {
                    View.Display(ex.Message);
                    Logger.Error(ex, ex.Message);
                }
                catch (ArgumentException ex)
                {
                    View.Display(ex.Message);
                    Logger.Error(ex, ex.Message);
                }
            } while (View.ContinueWork(Settings.CONTINUATION_STRING));

            var sortedTriangles = myTriangles.OrderBy( t => t.Area );

            if (sortedTriangles.Count() != 0)
            {
                View.Display(Settings.TITLE);
                foreach (var k in sortedTriangles)
                {
                    View.Display(k.ToString());
                }

                Logger.Info(Settings.APP_SORT);
            }
            else
            {
                View.Display(Settings.NO_ELEMENTS);
                Logger.Info(Settings.APP_NO_SORT);
            }

            View.Saybye();
        }

     
    }
}
