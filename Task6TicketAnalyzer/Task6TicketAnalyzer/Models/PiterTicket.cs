using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6TicketAnalyzer
{
    class PiterTicket: IAlgorithmTicket
    {       
        public int GetAllLucky(uint start, uint max)
        {
            int result = 0;
            for (uint i = start; i <= max; i++)
            {
                if (getParityNumsSum(i, false) == getParityNumsSum(i, true))
                {
                    result++;
                }
            }
            return result;
        }

        private uint getParityNumsSum(uint num, bool parity)
        {
            int parityNum = parity ? 0 : 1;

            uint answer = 0;

            for(int digitIndex = 0; num > 0; digitIndex++)
            {
                if (digitIndex % 2 == parityNum)
                {
                    answer += num % 10;
                }
                num = num / 10;
            }
                        
            return answer;
        }

    }
}
