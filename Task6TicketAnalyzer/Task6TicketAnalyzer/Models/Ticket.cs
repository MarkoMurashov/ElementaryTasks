using System;

namespace Task6TicketAnalyzer
{
    class Ticket
    {
        public uint Start { get; set; }

        public uint End { get; set; }

        public IAlgorithmTicket Algorith {private get; set; }

        public Ticket(uint start, uint end, IAlgorithmTicket algorith)
        {
            Algorith = algorith;
            Start = start;
            End = end;
        }

        public int GetAllLuckyNumber() => Algorith.GetAllLucky(Start,End);  
  

    }
}
