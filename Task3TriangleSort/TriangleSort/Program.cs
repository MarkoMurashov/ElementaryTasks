using NLog;
using ViewController;

namespace TriangleSort
{
    class Program
    {
        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {          
            new Application(new ConsoleUI(), logger).Run();
        }
    }
}
