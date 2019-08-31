using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceValidation
{
    public class ValidationArgs: IValid
    {
        public T GetValidArgs<T>(string[] args) where T: Enum
        {
            if (!Enum.IsDefined(typeof(T), args.Length))
            {
                throw new Exception("Ooops ... Data was incorrectly entered.");
            }

            return (T)Enum.ToObject(typeof(T), args.Length);
        }

        public void ExchangeValue(ref int first, ref int second)
        {
            int tmp = first;
            first = second;
            second = tmp;
        }
    }
}
