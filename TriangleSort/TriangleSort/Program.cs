using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            } while (Helper.ContinueWork());

            UI.ShowMessage(Settings.TITLE);

            foreach (var k in myTriangles)
            {
                UI.ShowMessage(k.ToString());
            }

            Helper.Saybye();
        }
    }
}
