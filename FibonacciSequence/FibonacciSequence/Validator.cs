using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
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
            if (result > 100000)
            {
                UI.ShowMessage(Settings.BIG);
                Helper.Saybye();
                Environment.Exit(0);
            }
            return result;
        }

        public static bool CheckNumberOfArgs(string[] args)
        {
            if(args.Length == 0)
            {
                UI.ShowMessage(Settings.INSTRUCTION);
                Helper.Saybye();
                Environment.Exit(0);
            }
            return args.Length == 2;
        }
    }
}
