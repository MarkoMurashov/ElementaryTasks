using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ViewController;

namespace Boards
{
    static class ViewContollerExtension
    {
        public static void PrintBoard(this IView view, Board board)
        {
            for (int i = 0; i < board.Cells.GetLength(0); i++)
            {
                for (int j = 0; j < board.Cells.GetLength(1); j++)
                {

                    if ((i + j) % 2 == 0)
                    {
                        view.SetConsoleColor(ConsoleColor.Black);
                    }
                    else
                    {
                        view.SetConsoleColor(ConsoleColor.White);
                    }
                    view.ShowShortMessage(board.Cells[i, j].ToString());
                }
                view.Display();
            }
            view.SetConsoleColor(ConsoleColor.Black);
            view.Saybye();
        }
    }
}
