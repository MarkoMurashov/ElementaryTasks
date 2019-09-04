using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6TicketAnalyzer
{
    class PiterTicket: IAlgorithTicket
    {
        public bool IsLucky(Ticket ticket)
        {
            if (ticket.Lenght % 2 == 1)
            {
                throw new Exception(Settings.LENGTH_ERROR);
            }

            int middle = ticket.Lenght / 2;
            byte firstSum = 0;
            byte secondSum = 0;
            for (int i = 0, j=1 ; i < middle; i+=2, j+=2)
            {
                firstSum += ticket[i];
                secondSum += ticket[j];
            }

            return (firstSum == secondSum);
        }
    }
}
