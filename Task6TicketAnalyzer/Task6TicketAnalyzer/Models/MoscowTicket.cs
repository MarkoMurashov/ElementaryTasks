using System;

namespace Task6TicketAnalyzer
{
    class MoscowTicket : IAlgorithmTicket
    {
        public int GetAllLucky(uint start, uint max)
        {
            int luckyTicket = 0;
            for (uint i = start; i <= max; i++)
            {
                for (uint j = start; j <= max; j++)
                {
                    if (CalculateSum(i) == CalculateSum(j))
                    {
                        luckyTicket++;
                    }
                }
            }

            return luckyTicket;
        }

        private uint CalculateSum(uint number)
        {
            uint answer = 0;
            while (number > 0)
            {
                answer += number % 10;
                number = number / 10;
            }
            return answer;
        }

       

    }
}
