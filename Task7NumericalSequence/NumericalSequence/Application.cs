using System;
using System.Text;
using NLog;
using ViewController;

namespace NumericalSequence
{
    public class Application
    {
        #region Properties

        private IView View { get; set; }

        private ILogger Logger { get; set; }

        #endregion

        #region Ctor

        public Application(IView view, ILogger log)
        {
            View = view;
            Logger = log;
        }

        #endregion

        public void Run(string[] args)
        {
            Logger.Info(Settings.APP_START);

            string sequence = string.Empty;
            CommandLineParser parser = new CommandLineParser(args);
            try
            {
                Operation op = parser.GetOperation<Operation>();

                switch (op)
                {
                    case Operation.ShowInstruction:
                        View.Display(Settings.INSTRUCTION);
                        return;
                    case Operation.Quadtratic:
                        sequence = GetQuadratic(args[0]);
                        break;
                }
            }
            catch (FormatException ex)
            {
                View.DisplayError(ex);
                Logger.Error(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                View.DisplayError(ex);
                Logger.Error(ex.Message);
            }
            catch (InvalidCastException ex)
            {
                View.DisplayError(ex);
                Logger.Error(ex.Message);
            }

            if (sequence.Length > 0)
            {
                View.Display(sequence);
                Logger.Info(Settings.APP_GENERATE);
            }
            else
            {
                View.Display(Settings.NO_MATCH);
                Logger.Info(Settings.APP_NO_RESULT);
            }
            View.Saybye();
        }

        public static string GetQuadratic(string arg)
        {
            ISequenceParser sequenceValidation = new NumberParser(Settings.NUMBER_LIMIT);
            int sequenceEnd = sequenceValidation.Parse(arg);

            SequenceGenerator sequence = new SequenceGenerator(new QuadraticSequence(sequenceEnd));

            return string.Join(", ", sequence.Create());
        }
    }
}
