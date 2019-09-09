using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalSequence
{
    public class NumberParser : ISequenceParser
    {
        private int MaxValue { get; set; }

        public NumberParser(int maxValue)
        {
            MaxValue = maxValue;
        }

        public int Parse(string number)
        {
            if (!int.TryParse(number, out int num))
            {
                throw new FormatException(Settings.WRONG_DATA);
            }
            if (num > MaxValue)
            {
                throw new ArgumentOutOfRangeException(Settings.BIG);
            }
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException(Settings.INSTRUCTION);
            }

            return num;
        }

    }
}
