using Assistant;
using System.IO;
using System;

using FileParser.UI;
using FileParser.Interfaces;

namespace FileParser
{
    class Program
    {
        static void Main(string[] args)
        {
            IValid validation = new ValidationArgs();
            try
            {
                Operation op = validation.isNumbeOfArgsValid(args);

                switch (op)
                {
                    case Operation.Instruction:
                        new ResultController(Settings.INSTRUCTION).Show();
                        break;

                    case Operation.Search:
                        ISearch s = new Searcher();
                        string result = string.Format(Settings.MATCH, s.SearchSubstring(args[0].CheckPath(), args[1]));
                        new ResultController(result).Show();
                        break;

                    case Operation.Replace:
                        IReplace r = new Replacer();
                        r.ReplaceStringInFile(args[0].CheckPath(), args[1], args[2]);
                        new ResultController(Settings.DONE).Show();
                        break;
                }

            }
            catch (Exception ex)
            {
                new ResultController(ex).Show();
            }
        }
    }
}
