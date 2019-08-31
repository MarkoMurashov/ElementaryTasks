using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SequenceValidation;
using SequenceGenerator;
using Controllers;

namespace NumericalSequence
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
                    case Operation.Quadtratic:
                        CreatorSequence sequence = new CreatorSequence(new QuadraticSequence(args[0].ParseArgs(Settings.NUMBER_LIMIT)));
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
