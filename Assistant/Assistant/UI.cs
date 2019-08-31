using System;


namespace Assistant
{
    public class UI
    {
        public static void ShowMessage(string str = "")
        {
            Console.WriteLine(str);
        }

        public static void ShowShortMessage(string str)
        {
            Console.Write(str);
        }

        public static string ReadData()
        {
            return Console.ReadLine();
        }

        public static void SetConsoleColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }
        
        public static void Saybye()
        {
            ShowMessage("\nPress any key to continue ...");
            ReadData();
        }

        public static bool ContinueWork(string cont)
        {
            ShowMessage(cont);
            string agrement = ReadData().ToUpper();

            return agrement == "Y" || agrement == "YES";
        }
    }
}
