using System.Collections.Generic;

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
