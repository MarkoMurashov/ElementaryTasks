using System;
using Assistant;

namespace Boards
{
    class Board
    {
        char[,] _cells;
        public Board(int numberOfRows, int NumverOfColumns)
        {
            _cells = new char[numberOfRows, NumverOfColumns];
            Fill();
        }

        void Fill()
        {
            for (int i = 0; i < _cells.GetLength(0); i++)
            {
                for (int j = 0; j < _cells.GetLength(1); j++)
                {
                    _cells[i, j] = ' ';
                }
            }
        }
        public void Show()
        {
            bool color = true;
            for (int i = 0; i < _cells.GetLength(0); i++)
            {
                if (_cells.GetLength(0) % 2 == 0)
                {
                    PaintConsole(ref color);
                }
                for (int j = 0; j < _cells.GetLength(1); j++)
                {
                    PaintConsole(ref color);

                    UI.ShowMessage(_cells[i, j].ToString());
                }
                UI.ShowMessageWithNewLine();
            }
            UI.ReadData();
        }

        void PaintConsole(ref bool color)
        {
            if (color)
            {
                UI.SetConsoleColor(ConsoleColor.White);
                color = false;
            }
            else
            {
                UI.SetConsoleColor(ConsoleColor.Black);
                color = true;
            }
        }
    }
}
