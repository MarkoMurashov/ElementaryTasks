using ViewController;
using ConsoleArgsValidation;

namespace Boards
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            new Application(new CommandLineValidation(), new ConsoleUI()).Run(args);      
        }
    }
}
