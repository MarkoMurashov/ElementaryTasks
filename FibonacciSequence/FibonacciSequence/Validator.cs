using System;

using Assistant;

namespace FibonacciSequence
{
    static class Validator
    {
        public static int CheckInt(this string tmp)
        {
            int result;
            if (!int.TryParse(tmp, out result))
            {
                UI.ShowMessageWithNewLine(Settings.WRONG_DATA);
                Assistant.Helper.Saybye();
                Environment.Exit(0);
            }
            if (result > 100000)
            {
                UI.ShowMessageWithNewLine(Settings.BIG);
                Assistant.Helper.Saybye();
                Environment.Exit(0);
            }
            return result;
        }

        public static bool CheckNumberOfArgs(string[] args)
        {
            if(args.Length == 0)
            {
                UI.ShowMessageWithNewLine(Settings.INSTRUCTION);
                Assistant.Helper.Saybye();
                Environment.Exit(0);
            }
            return args.Length == 2;
        }
    }
}
