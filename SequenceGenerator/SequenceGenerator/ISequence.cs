using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceGenerator
{
    public interface ISequence
    {
        IEnumerable<int> GenerateSequence();
    }
}
