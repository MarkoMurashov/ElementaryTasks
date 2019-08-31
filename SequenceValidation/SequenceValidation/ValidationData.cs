using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceValidation
{
    public static class ValidationData
    {
        public static int[] CheckNaturalNumber(this string[] strArr,int limit)
        {
            int length = strArr.Length;
            int[] intArr = new int[length];
            for (int i = length - 1; i >= 0; i--)
            {
                intArr[i] = ParseArgs(strArr[i], limit);
            }

            return intArr;
        }

        public static int ParseArgs(this string str, int limit)
        {
            int num;

            if (!int.TryParse(str, out num))
            {
                throw new Exception("Ooops ... Data was incorrectly entered.");
            }
            if (num > limit)
            {
                throw new Exception("Very big number :(");
            }
            if (num < 0)
            {
                throw new Exception("Please enter a positive integer number.");
            }

            return num;
        }

        public static void ExchangeValue(ref int first, ref int second)
        {
            int tmp = first;
            first = second;
            second = tmp;
        }
    }
}
