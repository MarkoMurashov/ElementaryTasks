using System.Collections.Generic;
using Assistant;

namespace TriangleSort
{
    static class Helper
    {
        public static void AddToSet(SortedSet<Triangle> myTriangles)
        {
            UI.ShowMessageWithNewLine(Settings.INVITATION);
            string[] result;
            if (Validator.CheckTriangleIngo(out result))
            {
                myTriangles.Add(new Triangle(result[0], result[1].ChageToDouble(), result[2].ChageToDouble(), result[3].ChageToDouble()));
            }
        }
       
    }
}
