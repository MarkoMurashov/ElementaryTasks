using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileParser.Interfaces
{
    interface IValid
    {
        Operation GetValidArgs(string[] args);
    }
}
