using ViewController;
using ConsoleArgsValidation;

namespace TriangleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            new Application(new CommandLineValidation(), new ConsoleUI()).Run();
        }
    }
}
