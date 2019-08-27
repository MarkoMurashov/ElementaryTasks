using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Validator.CheckNumberOfArgs(args))
            {
                Helper.SearchFibonacciNumbers(args[0].CheckInt(), args[1].CheckInt());
            }
            else
            {
                UI.ShowMessage(Settings.WRONG_NUMBER_OF_ARGS);
            }
            Helper.Saybye();
        }
    }
}
