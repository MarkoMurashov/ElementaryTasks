using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSort
{
    static class Helper
    {
        public static void AddToSet(SortedSet<Triangle> myTriangles)
        {
            UI.ShowMessage(Settings.INVITATION);
            string[] result;
            if (Validator.CheckTriangleIngo(out result))
            {
                myTriangles.Add(new Triangle(result[0], result[1].ChageToDouble(), result[2].ChageToDouble(), result[3].ChageToDouble()));
            }
        }

        public static bool ContinueWork()
        {
            UI.ShowMessage((Settings.CONTINUATION_STRING));
            string agrement = UI.ReadData().ToUpper();

            return agrement == Settings.SHORT_YES || agrement == Settings.LONG_YES;
        }

        public static void Saybye()
        {
            UI.ShowMessage(Settings.BYE);
            UI.ReadData();
        }
    }
}
