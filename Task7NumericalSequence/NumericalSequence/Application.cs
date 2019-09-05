using System;

using ConsoleArgsValidation;
using ViewController;
using SequenceGenerator;

namespace NumericalSequence
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
                Operation op = Validation.GetValidOperation<Operation>(args);

                switch (op)
                {
                    case Operation.Instruction:
                        View.Display(Settings.INSTRUCTION);
                        break;
                    case Operation.Quadtratic:
                        ISequenceValidation sequenceValidation = new PositiveNumber();
                        int sequenceEnd = sequenceValidation.ParsePositiveNumber(args[0],Settings.NUMBER_LIMIT);

                        CreatorSequence sequence = new CreatorSequence(new QuadraticSequence(sequenceEnd));
                        string fibonacci = string.Join(", ", sequence.Create());

                        if (fibonacci.Length > 0)
                        {
                            View.Display(fibonacci);
                            break;
                        }
                        
                        View.Display(Settings.NO_MATCH);
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
