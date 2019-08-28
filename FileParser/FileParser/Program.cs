using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileParser
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Validator.CheckNumberOfArgs(args))
            {
               Helper.ShowAnswer(Helper.SearchSubstring(args[0],args[1]));
            }
            else
            {
                Helper.ReplaceStringInFile(args[0], args[1], args[2]);
            }
            Helper.Saybye();
        }
    }
}
