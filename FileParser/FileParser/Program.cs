using Assistant;

namespace FileParser
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Validator.CheckNumberOfArgs(args))
            {
               Helper.ShowAnswer(Helper.SearchSubstring(args[0],args[1]));
            }
            else
            {
                Helper.ReplaceStringInFile(args[0], args[1], args[2]);
            }
            Assistant.Helper.Saybye();
        }
    }
}
