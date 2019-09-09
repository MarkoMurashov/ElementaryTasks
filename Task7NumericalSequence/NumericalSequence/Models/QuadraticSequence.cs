using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NumericalSequence
{
    public class QuadraticSequence : ISequence
    {
        public int End { get; private set; }

        public QuadraticSequence(int end)
        {
            End = end;
        }

        public IEnumerable<int> GenerateSequence()
        {
            for (int i = 1; i * i < End; i++)
            {
                yield return i;
            }
        }
    }
}
