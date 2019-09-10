using System;

namespace NumericalSequence
{
    public class NumberParser : ISequenceParser
    {
        #region Properties

        private int MaxValue { get; set; }

        #endregion

        #region Ctor

        public NumberParser(int maxValue)
        {
            MaxValue = maxValue;
        }

        #endregion

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
