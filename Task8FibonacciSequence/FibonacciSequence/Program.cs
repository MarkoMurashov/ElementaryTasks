using ConsoleArgsValidation;
using ViewController;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            new Application(new CommandLineValidation(), new ConsoleUI()).Run(args);
        }
    }
}
