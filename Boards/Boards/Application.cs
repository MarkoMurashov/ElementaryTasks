using System;

using Boards.Interfaces;
using Boards.Enums;
using Boards.View;
using Boards.ValidationControl;

namespace Boards
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
               

                switch (op)
                {
                    case Operation.Instruction:
                        new ViewController(Settings.INSTRUCTION).Show();
                        break;

                    case Operation.Print:
                        IBoardable view = new ViewController();
                        view.PrintBoard(Board.getBoard(args[0].CheckNaturalNumber(Settings.NUMBER_LIMIT),
                            args[1].CheckNaturalNumber(Settings.NUMBER_LIMIT)));                        
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
