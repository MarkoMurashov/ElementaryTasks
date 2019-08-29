using System;

using FileParser.Interfaces;
using FileParser.UI;

namespace FileParser
{
    class Application
    {

        private IValid _validation;

        public Application(IValid valid)
        {
            _validation = valid;
        }

        public void Run(string[] args)
        {
            try
            {
                Operation op = _validation.GetValidArgs(args);

                FileParser fileParser;
                switch (op)
                {
                    case Operation.Instruction:
                        new ResultController(Settings.INSTRUCTION).Show();
                        break;

                    case Operation.Search:
                        fileParser = new FileParser(args[0].CheckPath(), args[1], new Searcher());
                        string result = string.Format(Settings.MATCH, fileParser.DoAlgorithn());
                        new ResultController(result).Show();
                        break;

                    case Operation.Replace:
                        fileParser = new FileParser(args[0].CheckPath(), args[1], new Replacer(args[2]));
                        fileParser.DoAlgorithn();
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
