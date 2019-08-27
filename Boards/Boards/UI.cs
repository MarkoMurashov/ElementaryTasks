using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boards
{
    static class UI
    {
        public static void ShowMessageWithNewLine(string str = "")
        {
            Console.WriteLine(str);
        }

        public static void ShowMessage(string str)
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
    }
}
