using System;

using Task4FileParser.Interfaces;
using Task4FileParser.UI;

namespace Task4FileParser
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

                string substringNumber=string.Empty;

                FileParser fileParser;

                switch (op)
                {
                    case Operation.Instruction:
                        new ResultController(Settings.INSTRUCTION).Show();
                        break;

                    case Operation.Search:
                        fileParser = new FileParser(args[0].CheckPath(), args[1], new Searcher());
                        substringNumber = string.Format(Settings.MATCH, fileParser.DoAlgorithn());
                        new ResultController(substringNumber).Show();
                        break;

                    case Operation.Replace:
                        fileParser = new FileParser(args[0].CheckPath(), args[1], new Replacer(args[2]));
                        substringNumber = string.Format(Settings.REPLACED, fileParser.DoAlgorithn()); 
                        new ResultController(substringNumber).Show();
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
