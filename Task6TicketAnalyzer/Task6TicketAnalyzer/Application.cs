using System;
using System.Collections.Generic;
using System.IO;

using ViewController;
using ConsoleArgsValidation;

namespace Task6TicketAnalyzer
{
    class Application
    {
        private IValid Validation { get; set; }

        private IView View { get; set; }

        public Application(IValid valid, IView view)
        {
            Validation = valid;
            View = view;
        }

        public void Run(string[] args)
        {
            string algType = string.Empty;

            using (StreamReader reader = new StreamReader(args[0]))
            {
                algType = reader.ReadLine();               
            }

            Enum.TryParse(algType, out TicketType type);
            uint start;
            uint end;
            string luckyNumber;
            Ticket ticket;
            switch (type)
            {
                case TicketType.Moscow:
                    start = 100;
                    end = 999;
                    ticket = new Ticket(start, end, new MoscowTicket());
                    luckyNumber = string.Format("{0}", ticket.GetAllLuckyNumber());
                    View.Display(luckyNumber);
                    break;

                case TicketType.Piter:
                    start = 100;
                    end = 999;
                    ticket = new Ticket(start, end, new MoscowTicket());
                    luckyNumber = string.Format("{0}", ticket.GetAllLuckyNumber());
                    View.Display(luckyNumber);
                    break;


                default:
                    Console.WriteLine("12345");
                    break;

            }
           

            View.Saybye();
        }
     
    }
}
