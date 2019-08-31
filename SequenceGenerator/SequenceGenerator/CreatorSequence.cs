using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceGenerator
{
    public class CreatorSequence
    {
        public ISequence Sequence { private get; set; }

        public CreatorSequence(ISequence sequence)
        {
            Sequence = sequence;
        }

        public IEnumerable<int> Create()
        {
            return Sequence.GenerateSequence();
        }
    }
}
