using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArgsValidation
{
    public interface ISequenceValidation
    {
        int ParsePositiveNumber(string str, int maxValue);

        void ExchangeIntValue(ref int first, ref int second);
        
    }
}
