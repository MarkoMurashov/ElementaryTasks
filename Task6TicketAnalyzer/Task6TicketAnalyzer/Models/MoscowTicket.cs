using System;

namespace Task6TicketAnalyzer
{
    class MoscowTicket : IAlgorithmTicket
    {
        public int GetAllLucky(byte power)
        {
            int luckyTicket = 0;
            double max = Math.Pow(10, power);
            for (uint i = 0; i < max; i++)
            {
                for (uint j = 0; j < max ; j++)
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
