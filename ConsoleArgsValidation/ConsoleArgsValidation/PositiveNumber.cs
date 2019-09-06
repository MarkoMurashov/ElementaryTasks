using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArgsValidation
{
    public class PositiveNumber: ISequenceValidation
    {
        public int ParsePositiveNumber(string str, int maxValue)
        {
            if (!int.TryParse(str, out int num))
            {
                throw new FormatException("Ooops ... Data was incorrectly entered.");
            }
            if (num > maxValue)
            {
                throw new ArgumentOutOfRangeException("Very big number :(");
            }
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException("Please enter a positive integer number.");
            }

            return num;
        }

        public void ExchangeIntValue(ref int first, ref int second)
        {
            int tmp = first;
            first = second;
            second = tmp;
        }
    }
}
