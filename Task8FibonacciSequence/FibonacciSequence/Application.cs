using System;

using SequenceValidation;
using SequenceGenerator;
using Controllers;

namespace FibonacciSequence
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
                Operation op = _validation.GetValidArgs<Operation>(args);

                switch (op)
                {
                    case Operation.Instruction:
                        new ViewController(Settings.INSTRUCTION).Show();
                        break;
                    
                    case Operation.Fibonacci:
                        int[] diapason = args.CheckNaturalNumber(Settings.NUMBER_LIMIT);
                        if (diapason[0] > diapason[1])
                        {
                            _validation.ExchangeValue(ref diapason[0], ref diapason[1]);
                        }
                        CreatorSequence sequence = new CreatorSequence(new FibonacciGenerator(diapason[0], diapason[1]));
                        string fibonacci = string.Join(", ", sequence.Create());
                        if (fibonacci.Length > 0)
                        {
                            new ViewController(fibonacci).Show();
                        }
                        else
                        {
                            new ViewController(Settings.NO_MATCH).Show();
                        }
                        break;                 
                }

            }
            catch (Exception ex)
            {
                new ViewController(ex).Show();
            }
        }
    }
}
