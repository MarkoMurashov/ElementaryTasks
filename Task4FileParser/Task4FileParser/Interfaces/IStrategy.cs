using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4FileParser
{
    public interface IStrategy
    {
         int Algorithm(string path, string substring);
    }
}
