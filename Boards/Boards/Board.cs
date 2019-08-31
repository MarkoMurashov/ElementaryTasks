using System;
using Assistant;

namespace Boards
{
    class Board
    {
        private static Board board;

        public char[,] Cells { get; set; }

        private Board(int numberOfRows, int NumverOfColumns)
        {
            Cells = new char[numberOfRows, NumverOfColumns];
            Fill();
        }

        void Fill()
        {
            for (int i = 0; i < Cells.GetLength(0); i++)
            {
                for (int j = 0; j < Cells.GetLength(1); j++)
                {
                    Cells[i, j] = ' ';
                }
            }
        }
            
        public static Board getBoard(int numberOfRows, int NumverOfColumns)
        {
            if (board == null)
                board = new Board( numberOfRows, NumverOfColumns);
            return board;
        }
       
    }
}
