using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6TicketAnalyzer
{
    class Ticket
    {
        private byte[] Number { get; set; }

        public int Lenght
        {
            get
            {
                return Number.Length;
            }
        }

        public IAlgorithTicket Algorith { private get; set; }

        public Ticket(byte[] num, IAlgorithTicket algorith)
        {
            Number = num;
            Algorith = algorith;
        }

        public byte this[int index]
        {
            get
            {
                return Number[index];
            }
            set
            {
                Number[index] = value;
            }
        }


        public bool AnaLyze()
        {
            return Algorith.IsLucky(this);
        }

    }
}
