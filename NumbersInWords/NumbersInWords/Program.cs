namespace NumbersInWords
{        
    class Program
    {

        static void Main(string[] args)
        {
            if (args.CheckNumberOfArgs())
            {
                UI.ShowMessage(Settings.INSTRUCTION);
                Helper.Saybye();
                return;
            }
            Validator.CheckInt(args[0]);
            UI.ShowMessage(Helper.ConvertWithPower(args[0]));
            UI.ReadData();

        }
    }
}
