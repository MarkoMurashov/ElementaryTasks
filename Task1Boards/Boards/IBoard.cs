﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boards
{
    interface IBoard
    {
        char[,] Cells { get; set; }
    }
}