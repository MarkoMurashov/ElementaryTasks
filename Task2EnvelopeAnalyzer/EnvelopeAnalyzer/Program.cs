using ConsoleArgsValidation;
using ViewController;

namespace EnvelopeAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            new Application(new ConsoleUI()).Run();      
        }
    }
}
