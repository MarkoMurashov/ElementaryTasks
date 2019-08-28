using System;

namespace EnvelopeAnalyzer
{
    static class Validator
    {
        public static double CheckData(string invitation)
        {
            UI.ShowMessage(invitation);
            double result;
            if (!double.TryParse(Console.ReadLine(), out result) || result <= 0)
            {
                UI.ShowMessage(Settings.WRONG_DATA);
                UI.ReadData();
                Environment.Exit(0);
            }
            return result;
        }
    }
}
