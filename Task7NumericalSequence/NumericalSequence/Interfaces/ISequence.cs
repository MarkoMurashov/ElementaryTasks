using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalSequence
{
    interface ISequence
    {
        IEnumerable<int> GenerateSequence();
    }
}
