using Assistant;

namespace NumericalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Validator.CheckNumberOfArgs(args))
            {
                Helper.SearchAnswer(args[0].CheckInt());
            }
            else
            {
                UI.ShowMessageWithNewLine(Settings.INSTRUCTION);
            }
            Assistant.Helper.Saybye();
        }
    }
}
