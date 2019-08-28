using System;
using Assistant;

namespace Boards
{
    static class Validator
    {
        public static int CheckNaturalNumber(this string str)
        {
            int res;
            if (!int.TryParse(str, out res) || res <= 0)
            {
                UI.ShowMessageWithNewLine(Settings.WRONG_DATA);
                Environment.Exit(0);
            }
            if (res > 250)
            {
                UI.ShowMessageWithNewLine(Settings.BIG_NUM);
                Environment.Exit(0);
            }
            return res;
        }

        public static bool CheckNumberOfArgs(string[] args)
        {
            if (args.Length == 2)
            {
                return true;
            }
            if (args.Length == 0)
            {
                UI.ShowMessageWithNewLine(Settings.INSTRUCTION);
                return false;
            }
            else
            {
                UI.ShowMessageWithNewLine(Settings.WRONG_NUMBER_OF_ARGS);
                return false;
            }
        }
    }
}
