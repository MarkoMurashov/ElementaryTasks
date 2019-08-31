using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceValidation
{
    public interface IValid
    {
        T GetValidArgs<T>(string[] args) where T : Enum;

        void ExchangeValue(ref int first, ref int second);
    }
}
