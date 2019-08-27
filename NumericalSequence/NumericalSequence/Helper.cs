using System.Collections.Generic;

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
            UI.ShowMessage(string.Join(", ", answer));      
        }
        public static void Saybye()
        {
            UI.ShowMessage(Settings.BYE);
            UI.ReadData();
        }
    }
}
