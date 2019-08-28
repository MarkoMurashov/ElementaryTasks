using System;
using System.IO;

using Assistant;

namespace FileParser
{
    class Validator
    {
        public static bool CheckNumberOfArgs(string[] args)
        {
            if (args.Length == 0 || args.Length > 4)
            {
                UI.ShowMessageWithNewLine(Settings.INSTRUCTION);
                Assistant.Helper.Saybye();
                Environment.Exit(0);
            }
            return args.Length == 2;
        }

        public static bool IsFileExist(string path)
        {           
            if (!File.Exists(path))
            {
                UI.ShowMessageWithNewLine(Settings.WRONG_PATH);
                Assistant.Helper.Saybye();
                Environment.Exit(0);
            }
            return true;
        }
    }
}
