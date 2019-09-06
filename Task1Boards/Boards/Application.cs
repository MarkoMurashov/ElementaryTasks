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
                Operation op = Validation.GetValidOperation<Operation>(args);


                switch (op)
                {
                    case Operation.Instruction:
                        View.Display(Settings.INSTRUCTION);
                        break;

                    case Operation.Print:
                        IBoard board = Validation.GetValidBoard(args[0], args[1]);
                        View.PrintBoard(board);                        
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
        }
    }
}
