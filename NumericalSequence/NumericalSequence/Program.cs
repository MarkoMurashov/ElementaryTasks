
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
                UI.ShowMessage(Settings.INSTRUCTION);
            }
            Helper.Saybye();
        }
    }
}
