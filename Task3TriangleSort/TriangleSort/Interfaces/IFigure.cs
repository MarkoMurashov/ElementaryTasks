using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSort
{
    public interface IFigure
    {
        string Name { get; }
        double[] Sides { get; }
        double Square { get; }

        bool Equals(object obj);
    }
}
