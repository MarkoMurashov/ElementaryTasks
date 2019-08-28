using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSort
{
    class SortTrianglesBySquare : IComparer<Triangle>
    {
        int IComparer<Triangle>.Compare(Triangle first, Triangle second)
        {
            return first.Square.CompareTo(second.Square);
        }
    }
}
