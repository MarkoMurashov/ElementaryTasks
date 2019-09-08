using System;

using ViewController;

namespace NumericalSequence
{
    class Application
    {
        private IView View { get; set; }

        public Application(IView view)
        {
            View = view;
        }

        public void Run(string[] args)
        {
            try
            {
                CommandLineParser parser = new CommandLineParser(args);
                Operation op = parser.GetOperation<Operation>();

                switch (op)
                {
                    case Operation.Instruction:
                        View.Display(Settings.INSTRUCTION);
                        break;
                    case Operation.Quadtratic:
                        string sequence = GetQuadratic(args[0]);

                        if (sequence.Length > 0)
                        {
                            View.Display(sequence);
                            break;
                        }
                        
                        View.Display(Settings.NO_MATCH);
                        break;
                    
                }
                View.Saybye();
            }
            catch (FormatException ex)
            {
                View.DisplayError(ex);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                View.DisplayError(ex);
            }
            catch (InvalidCastException ex)
            {
                View.DisplayError(ex);
            }
        }

        private string  GetQuadratic(string arg)
        {
            ISequenceParser sequenceValidation = new NumberParser(Settings.NUMBER_LIMIT);
            int sequenceEnd = sequenceValidation.TryParse(arg);

            SequenceGenerator sequence = new SequenceGenerator(new QuadraticSequence(sequenceEnd));

            return string.Join(", ", sequence.Create());
 
        }
    }
}
