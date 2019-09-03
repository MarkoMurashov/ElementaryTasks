using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewController
{
    public class ConsoleUI: IView
    {
        public string GetStringData(string inctruction)
        {
            Console.WriteLine(inctruction);

            return Console.ReadLine();
        }

        public void Display(string str="")
        {
            Console.WriteLine(str);
        }

        public void DisplayError(Exception ex)
        {
            Console.WriteLine(ex.Message);
            Saybye();
        }

        public void Saybye()
        {
            Console.WriteLine("\nPress any key to continue ...");
            Console.ReadLine();
        }
        
        public void ShowShortMessage(string str)
        {
            Console.Write(str);
        }
       
        public void SetConsoleColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }
        

        public bool ContinueWork(string message)
        {
            Console.WriteLine(message); 
            string agrement =Console.ReadLine().ToUpper();

            return agrement == "Y" || agrement == "YES";
        }
    }
}
