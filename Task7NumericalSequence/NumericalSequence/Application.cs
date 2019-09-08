using System;
using System.Collections.Generic;
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
            string sequence = string.Empty;
            CommandLineParser parser = new CommandLineParser(args);
            try
            {
                Status op = parser.GetOperation<Status>();
                    
                switch (op)
                {
                    case Status.Instruction:
                        View.Display(Settings.INSTRUCTION);
                        return;
                    case Status.Quadtratic:
                        sequence = GetQuadratic(args[0]);
                        break;
                }
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


            if (sequence.Length > 0)
            {
                View.Display(sequence);
            }
            else
            {
                View.Display(Settings.NO_MATCH);
            }
            View.Saybye();
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
