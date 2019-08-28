using System.Collections.Generic;
using Assistant;

namespace TriangleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Triangle> myTriangles = new SortedSet<Triangle>(new SortTrianglesBySquare());

            do
            {
                Helper.AddToSet(myTriangles);
            } while (Assistant.Helper.ContinueWork(Settings.CONTINUATION_STRING));

            UI.ShowMessageWithNewLine(Settings.TITLE);

            foreach (var k in myTriangles)
            {
                UI.ShowMessageWithNewLine(k.ToString());
            }

            Assistant.Helper.Saybye();
        }
    }
}
