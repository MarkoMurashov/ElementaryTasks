using System;

using Boards.Enums;
using ViewController;
using ConsoleArgsValidation;

namespace Boards
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
            View.SetConsoleColor(ConsoleColor.Black);

            try
            {
                Operation op = Validation.GetValidArgs<Operation>(args);
               

                switch (op)
                {
                    case Operation.Instruction:
                        View.Display(Settings.INSTRUCTION);
                        break;

                    case Operation.Print:
                        int firstIndex = Validation.GetValidIntArg(args[0]);
                        int secondIndex = Validation.GetValidIntArg(args[1]);

                        View.PrintBoard(Board.getBoard(firstIndex, secondIndex));                        
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
