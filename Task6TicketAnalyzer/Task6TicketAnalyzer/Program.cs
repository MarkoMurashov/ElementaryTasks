using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Task6TicketAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string algType= string.Empty;
          
            List<byte[]> smth = new List<byte[]>();

            using(StreamReader reader = new StreamReader("test.txt"))
            {
              
                algType = reader.ReadLine();

                while (reader.Peek() >= 0)
                {
                    string stra = reader.ReadLine();
                    byte[] asd = new byte[stra.Length];

                    for (int i = 0; i < stra.Length; i++)
                    {
                        byte.TryParse(stra[i].ToString(), out asd[i]);
                    }

                    smth.Add(asd);
                }

            }

            Enum.TryParse(algType, out TicketType type);

            switch(type)
            {
                case TicketType.Moscow:
                    foreach(var t in smth)
                    {
                          Ticket ticket = new Ticket(t, new MoscowTicket());
                          Console.WriteLine(ticket.AnaLyze());

                    }
                    
                    break;

                case TicketType.Piter:
                    foreach (var t in smth)
                    {
                        Ticket ticket = new Ticket(t, new PiterTicket());
                        Console.WriteLine(ticket.AnaLyze());

                    }
                    break;

                default:
                    Console.WriteLine("3");
                    break;
            }

            Console.ReadLine();
        }
    }
}
