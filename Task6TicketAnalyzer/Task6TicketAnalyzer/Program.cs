using ConsoleArgsValidation;
using ViewController;

namespace Task6TicketAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
           Application applicationm = new Application
                   (new CommandLineValidation(), new ConsoleUI(), new FileParser());
           applicationm.Run(args);
        }
    }
}
