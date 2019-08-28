using System.Collections.Generic;

using Assistant;

namespace NumericalSequence
{
    class Helper
    {
        public static void SearchAnswer(int a)
        {            
            List<int> answer = new List<int>();

            for (int i = 1; i * i < a; i++)
            {
                answer.Add(i*i);
            }
            UI.ShowMessageWithNewLine(string.Join(", ", answer));      
        }
      
    }
}
