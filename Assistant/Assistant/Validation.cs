using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistant
{
    static class Validation
    {
        public static int CheckNaturalNumber(this string str)
        {
            int res;
            if (!int.TryParse(str, out res) || res <= 0)
            {
                throw new Exception("Wrong data");
            }           
            return res;
        }
    }
}
