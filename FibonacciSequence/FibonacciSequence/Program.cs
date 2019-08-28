using Assistant;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Validator.CheckNumberOfArgs(args))
            {
                Helper.SearchFibonacciNumbers(args[0].CheckInt(), args[1].CheckInt());
            }
            else
            {
                UI.ShowMessageWithNewLine(Settings.WRONG_NUMBER_OF_ARGS);
            }
            Assistant.Helper.Saybye();
        }
    }
}
