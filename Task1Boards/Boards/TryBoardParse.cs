using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleArgsValidation;

namespace Boards
{
    static class TryBoardParse
    {
       public static Board GetValidBoard(this IValid valid, string rowIndex, string columnIndex)
       {
            byte numberOfRows = valid.GetValidByteArg(rowIndex);
            byte NumverOfColumns = valid.GetValidByteArg(columnIndex);

            if (numberOfRows <= 0 || NumverOfColumns <= 0)
            {
                throw new Exception(Settings.INSTRUCTION);
            }
            if (numberOfRows > 30 || NumverOfColumns > 100)
            {
                throw new Exception(Settings.BIG_NUM);
            }

            return new Board(numberOfRows, NumverOfColumns);
        }
    } 
    
}
