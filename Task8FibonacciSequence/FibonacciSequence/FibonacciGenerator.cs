using System.Collections.Generic;

using SequenceGenerator;

namespace FibonacciSequence
{
    class FibonacciGenerator:  ISequence
    {
        public int Start { get; set; }

        public int End { get; set; }

        public FibonacciGenerator(int start, int end)
        {
            Start = start;
            End = end;
        }
        public IEnumerable<int> GenerateSequence()
        {
           
            for (int i = 0, j = 1; i < End;)
            {
                if (i > Start && i < End)
                {
                    yield return i;
                }
                int tmp = j;
                j += i;
                i = tmp;
            }
           
        }
    }
}
