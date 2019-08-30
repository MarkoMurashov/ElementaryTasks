using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static void ShowAnswer(bool answer, string yes, string no)
        {
            if (answer)
            {
                Console.WriteLine(yes);
            }
            else
            {
                Console.WriteLine(no);
            }
        }
       

        public static void Saybye()
        {
            ShowMessage("\nPress any key to continue ...");
            ReadData();
        }
    }
}
