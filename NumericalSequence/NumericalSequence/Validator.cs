using System;

namespace NumericalSequence
{
    static class Validator
    {
        public static int CheckInt(this string tmp)
        {
            int result;
            if (!int.TryParse(tmp, out result))
            {
                UI.ShowMessage(Settings.WRONG_DATA);
                Helper.Saybye();
                Environment.Exit(0);
            }
            if (result > 10000)
            {
                UI.ShowMessage(Settings.BIG);
                Helper.Saybye();
                Environment.Exit(0);
            }
            return result;
        }

        public static bool CheckNumberOfArgs(string[] args)
        {
            return !(args.Length == 0);
        }
    }
}
