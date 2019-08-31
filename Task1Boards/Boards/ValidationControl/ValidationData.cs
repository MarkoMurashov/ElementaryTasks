using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boards.ValidationControl
{
    static class ValidationData
    {
        public static int CheckNaturalNumber(this string str,int limit)
        {
            int res;
            if (!int.TryParse(str, out res))
            {
                throw new Exception(Settings.WRONG_DATA);
            }
            if( res <= 0)
            {
                throw new Exception(Settings.ZERO_DATA);
            }
            if (res > limit)
            {
                throw new Exception(Settings.BIG_NUM);
            }
            return res;
        }
    }
}
