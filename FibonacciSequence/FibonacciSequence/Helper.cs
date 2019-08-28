using System.Collections.Generic;

using Assistant;

namespace FibonacciSequence
{
    class Helper
    {
        public static void SearchFibonacciNumbers(int start, int end)
        {
            List<int> answer = new List<int>();

            if(start > end)
            {
                ExchangeValue(ref start, ref end);
            }

            for (int i = 0, j = 1; i < end;)
            {
                if (i > start && i < end)
                {
                    answer.Add(i);
                }
                int tmp = j;
                j += i;
                i = tmp;
            }
           UI.ShowMessageWithNewLine(string.Join(", ", answer));
        }

        public static void ExchangeValue(ref int first, ref int second)
        {
            int tmp = first;
            first = second;
            second = tmp;
        }
       
    }
}
