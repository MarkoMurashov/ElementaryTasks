using System;

using ConsoleArgsValidation;
using ViewController;

namespace Task4FileParser
{
    class Application
    {

        private IValid Validation { get; set; }

        private IView View { get; set; }

        public Application(IValid valid, IView view)
        {
            Validation = valid;
            View = view;
        }

        public void Run(string[] args)
        {
            try
            {
                Operation op = Validation.GetValidArgs<Operation>(args);

                string substringNumber=string.Empty;
                FileParser fileParser;

                switch (op)
                {
                    case Operation.Instruction:
                        View.Display(Settings.INSTRUCTION);
                        break;

                    case Operation.Search:
                        if (Validation.CheckPath(args[0]))
                        {
                            fileParser = new FileParser(args[0], args[1], new Searcher());
                            substringNumber = string.Format(Settings.MATCH, fileParser.DoAlgorithn());
                            View.Display(substringNumber);
                        }
                        break;

                    case Operation.Replace:
                        if (Validation.CheckPath(args[0]))
                        {
                            fileParser = new FileParser(args[0], args[1], new Replacer(args[2]));
                            substringNumber = string.Format(Settings.REPLACED, fileParser.DoAlgorithn());
                            View.Display(substringNumber);
                        }                        
                        break;
                }

            }
            catch (Exception ex)
            {
                View.DisplayError(ex);
            }
        }
    }
}
