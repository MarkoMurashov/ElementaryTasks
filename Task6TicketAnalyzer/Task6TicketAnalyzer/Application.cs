using System;

using ViewController;
using ConsoleArgsValidation;

namespace Task6TicketAnalyzer
{
    class Application
    {
        #region Properties

        private IValid Validation { get; set; }

        private IView View { get; set; }

        public ISourceAlgorithm TypeAlgorithm { get; set; }

        public Application(IValid valid, IView view, ISourceAlgorithm typeAlgorithm)
        {
            Validation = valid;
            View = view;
            TypeAlgorithm = typeAlgorithm;
        }

        #endregion

        public void Run(string[] args)
        {
            try
            {
                Operation operation = Validation.GetValidOperation<Operation>(args);

                switch (operation)
                {
                    case Operation.Instruction:
                        View.Display(Settings.INSTRUCTION);
                        break;

                    case Operation.Analyze:
                        ExecuteAlgorithm(args[0]);
                        break;

                    default:
                        View.Display(Settings.INSTRUCTION);
                        break;
                }
                View.Saybye();
            }
            catch(Exception ex)
            {
                View.DisplayError(ex);
            }         
        }

        private void ExecuteAlgorithm(string path)
        {
            Validation.GetValidPath(path);
            TicketType type = TypeAlgorithm.GetAlgType(path);

            byte power = Validation.
                TryPowerParse(View.GetStringData(Settings.ENTER_POWER));

            power /= 2;

            switch (type)
            {
                case TicketType.Moscow:
                    View.PrintLuckyTicket(new Ticket(power, new MoscowTicket()));
                    break;

                case TicketType.Piter:
                    View.PrintLuckyTicket(new Ticket(power, new MoscowTicket()));
                    break;

                default:
                    View.Display(Settings.INSTRUCTION);
                    break;
            }
        }
    }
}
