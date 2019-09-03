using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewController
{
    public interface IView
    {
        string GetStringData(string inctruction);

        void Display(string str="");

        void Saybye();

        void DisplayError(Exception ex);

        void ShowShortMessage(string str);

        void SetConsoleColor(ConsoleColor color);

        bool ContinueWork(string message);
    }
}
