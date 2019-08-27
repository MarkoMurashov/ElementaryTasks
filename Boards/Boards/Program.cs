using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boards
{
    class Program
    {
        static void Main(string[] args)
        {
            UI.SetConsoleColor(ConsoleColor.Black);
            if (Validator.CheckNumberOfArgs(args))
            {
                Board myBoard = new Board(args[0].CheckNaturalNumber(), args[1].CheckNaturalNumber());
                myBoard.Show();
            }

       
        }
    }
}
