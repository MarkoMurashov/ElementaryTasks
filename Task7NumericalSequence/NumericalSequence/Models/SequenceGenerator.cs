using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalSequence
{
    public class SequenceGenerator
    {
        public ISequence Sequence { private get; set; }

        public SequenceGenerator(ISequence sequence)
        {
            Sequence = sequence;
        }

        public IEnumerable<int> Create()
        {
            if (Sequence == null)
            {
                throw new InvalidCastException(Settings.NULL_ERROR);
            }

            return Sequence.GenerateSequence();
        }
    }
}
