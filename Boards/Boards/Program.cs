using System;
using Assistant;

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
