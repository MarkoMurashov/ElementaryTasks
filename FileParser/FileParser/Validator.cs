using System;
using System.IO;

namespace FileParser
{
    class Validator
    {
        public static bool CheckNumberOfArgs(string[] args)
        {
            if (args.Length == 0 || args.Length > 4)
            {
                UI.ShowMessage(Settings.INSTRUCTION);
                Helper.Saybye();
                Environment.Exit(0);
            }
            return args.Length == 2;
        }

        public static bool IsFileExist(string path)
        {           
            if (!File.Exists(path))
            {
                UI.ShowMessage(Settings.WRONG_PATH);
                Helper.Saybye();
                Environment.Exit(0);
            }
            return true;
        }
    }
}
