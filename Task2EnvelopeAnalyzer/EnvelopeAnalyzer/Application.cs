using System;

using ConsoleArgsValidation;
using ViewController;

namespace EnvelopeAnalyzer
{
    class Application
    {
        private IView View { get; set; }

        public Application(IView view)
        {
            View = view;
        }

        public void Run()
        {
            
            do
            {
                try
                {
                    Envelope first = InitializeEnvelope(1);
                    Envelope second = InitializeEnvelope(2);

                    Status status = first.Compare(second);

                    switch (status)
                    {
                        case Status.FirstInSecond:
                            View.Display(Settings.ANSWER_YES_FIRST);
                            break;

                        case Status.SecondInFirst:
                            View.Display(Settings.ANSWER_YES_SECOND);
                            break;

                        case Status.None:
                            View.Display(Settings.ANSWER_NO);
                            break;

                        case Status.Equal:
                            View.Display(Settings.ANSWER_NO_EQUALS);
                            break;

                        default:
                            throw new ArgumentOutOfRangeException(Settings.NO_ANSWER);
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

            } while (View.ContinueWork(Settings.CONTINUE));

            View.Saybye();
        }

        public Envelope InitializeEnvelope(int envelopeNumber)
        {
            string message = string.Format(Settings.WIDTH, envelopeNumber);
            string width = View.GetStringData(message);

            message = string.Format(Settings.LENGTH, envelopeNumber);
            string length = View.GetStringData(message);

            return Envelope.Create(new CommandLineValidation(), width, length);
        }
        
    }
}
