using System;
using Assistant;

namespace EnvelopeAnalyzer
{
    static class Validator
    {
        public static double CheckData(string invitation)
        {
            UI.ShowMessageWithNewLine(invitation);
            double result;
            if (!double.TryParse(Console.ReadLine(), out result) || result <= 0)
            {
                UI.ShowMessageWithNewLine(Settings.WRONG_DATA);
                UI.ReadData();
                Environment.Exit(0);
            }
            return result;
        }
    }
}
