using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6TicketAnalyzer
{
    class MoscowTicket: IAlgorithTicket
    {
        public bool IsLucky(Ticket ticket)
        {
            if(ticket.Lenght % 2 == 1)
            {
                throw new Exception(Settings.LENGTH_ERROR);
            }

            int middle = ticket.Lenght / 2;
            byte firstSum = 0;
            byte secondSum = 0;
            for (int i = 0; middle < ticket.Lenght; i++, middle++)
            {
                firstSum += ticket[i];
                secondSum += ticket[middle];
            }

            return (firstSum == secondSum);
        }
    }
}
