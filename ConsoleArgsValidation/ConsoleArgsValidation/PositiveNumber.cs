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
                throw new Exception("Ooops ... Data was incorrectly entered.");
            }
            if (num > maxValue)
            {
                throw new Exception("Very big number :(");
            }
            if (num < 0)
            {
                throw new Exception("Please enter a positive integer number.");
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
