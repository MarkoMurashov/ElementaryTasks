using System;

namespace Boards
{
    class Board: IBoard
    {

        public char[,] Cells { get; set; }

        public Board(int numberOfRows, int NumverOfColumns)
        {
            Cells = new char[numberOfRows, NumverOfColumns];
            Fill();
        }

        private void Fill()
        {
            for (int i = 0; i < Cells.GetLength(0); i++)
            {
                for (int j = 0; j < Cells.GetLength(1); j++)
                {
                    Cells[i, j] = ' ';
                }
            }
        }
            
            
    }
}
