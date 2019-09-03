using System;


using SequenceGenerator;
using ConsoleArgsValidation;
using ViewController;

namespace FibonacciSequence
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

                switch (op)
                {
                    case Operation.Instruction:
                        View.Display(Settings.INSTRUCTION);
                        break;
                    
                    case Operation.Fibonacci:
                        int sequenceStart = Validation.ParsePositiveNumber(args[0], Settings.NUMBER_LIMIT);
                        int sequenceEnd = Validation.ParsePositiveNumber(args[1], Settings.NUMBER_LIMIT);
                        if (sequenceStart > sequenceEnd)
                        {
                            Validation.ExchangeIntValue(ref sequenceStart, ref sequenceEnd);
                        }
                        CreatorSequence sequence = new CreatorSequence(new FibonacciGenerator(sequenceStart, sequenceEnd));
                        string fibonacci = string.Join(", ", sequence.Create());
                        if (fibonacci.Length > 0)
                        {
                            View.Display(fibonacci);
                        }
                        else
                        {
                            View.Display(Settings.NO_MATCH);
                        }
                        break;                 
                }
                View.Saybye();

            }
            catch (Exception ex)
            {
                View.DisplayError(ex);
            }
        }
    }
}
