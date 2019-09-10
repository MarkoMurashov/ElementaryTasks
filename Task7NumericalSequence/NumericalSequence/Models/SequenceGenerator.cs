using System;
using System.Collections.Generic;

namespace NumericalSequence
{
    public class SequenceGenerator
    {
        #region Properties

        public ISequence Sequence { get; private set; }

        #endregion

        #region Ctor

        public SequenceGenerator(ISequence sequence)
        {
            Sequence = sequence;
        }

        #endregion

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
