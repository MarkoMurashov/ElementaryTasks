using System.Collections.Generic;

namespace NumericalSequence
{
    public interface ISequence
    {
        IEnumerable<int> GenerateSequence();
    }
}
