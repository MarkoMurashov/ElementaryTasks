
namespace Assistant
{
    public static class Helper
    {
        public static bool ContinueWork(string cont)
        {
            UI.ShowMessage(cont);
            string agrement = UI.ReadData().ToUpper();

            return agrement == "Y" || agrement == "YES";
        }

    }
}
