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
            if(numberOfRows <= 0 || NumverOfColumns <= 0)
            {
                throw new Exception(Settings.INSTRUCTION);
            }
            if (numberOfRows > 30 || NumverOfColumns > 100)
            {
                throw new Exception(Settings.BIG_NUM);
            }
            if (board == null)
            {
                board = new Board(numberOfRows, NumverOfColumns);
            }
            return board;
        }
       
    }
}
