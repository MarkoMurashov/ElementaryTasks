using System;

using Assistant;
using Boards.Interfaces;

namespace Boards.View
{
    class ViewController: IBoardable
    {
        private string _message { get; set; }

        public ViewController(Exception ex)
        {
            _message = ex.Message;
        }

        public ViewController(string message)
        {
            _message = message;
        }

        public ViewController()
        {
            _message = Settings.SUCCESS;
        }

        public void Show()
        {
            UI.ShowMessage(_message);
            UI.Saybye();
        }

        public void PrintBoard(Board board)
        {
            for (int i = 0; i < board.Cells.GetLength(0); i++)
            {
                for (int j = 0; j < board.Cells.GetLength(1); j++)
                {

                    if ((i + j) % 2 == 0)
                    {
                        UI.SetConsoleColor(ConsoleColor.Black);
                    }
                    else
                    {
                        UI.SetConsoleColor(ConsoleColor.White);
                    }
                    UI.ShowShortMessage(board.Cells[i, j].ToString());
                }
                UI.ShowMessage();
            }
            Show();
        }
      
    }
}
