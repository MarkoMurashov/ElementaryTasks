namespace Task6TicketAnalyzer
{
    class Ticket
    {
        public byte Power { get; set; }


        public IAlgorithmTicket Algorith {private get; set; }

        public Ticket(byte power,  IAlgorithmTicket algorith)
        {
            Algorith = algorith;
            Power = power;
        }

        public int GetAllLuckyNumber() => Algorith.GetAllLucky(Power);  
  

    }
}
