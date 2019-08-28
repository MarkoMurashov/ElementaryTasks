using System;

namespace NumbersInWords
{
    static class Validator
    {
        public static void CheckInt(string tmp)
        {
            int result;
            if (!int.TryParse(tmp, out result))
            {
                UI.ShowMessage(Settings.WRONG_DATA);
                Helper.Saybye();
                Environment.Exit(0);
            }
            if (result > 1999999999)
            {
                UI.ShowMessage(Settings.BIG);
                Helper.Saybye();
                Environment.Exit(0);
            }

        }

        public static bool CheckNumberOfArgs(this string[] args)
        {
            if (args.Length > 2)
            {
                UI.ShowMessage(Settings.WRONG_NUMBER_OF_ARGS);
                Helper.Saybye();
                Environment.Exit(0);
            }
            return args.Length == 0;
        }
    }
}
