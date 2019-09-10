using System.Collections.Generic;

namespace NumericalSequence
{
    public class QuadraticSequence : ISequence
    {
        #region Properties

        public int End { get; private set; }

        #endregion

        #region Ctor

        public QuadraticSequence(int end)
        {
            End = end;
        }

        #endregion

        public IEnumerable<int> GenerateSequence()
        {
            for (int i = 1; i * i < End; i++)
            {
                yield return i;
            }
        }
    }
}