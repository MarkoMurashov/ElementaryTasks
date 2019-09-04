using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;


using ConsoleArgsValidation;
using ViewController;
namespace Task6TicketAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            new Application(new CommandLineValidation(), new ConsoleUI()).Run(args);
        }
    }
}
