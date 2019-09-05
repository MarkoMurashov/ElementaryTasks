using Assistant;
using System.IO;
using System;

using ViewController;
using ConsoleArgsValidation;

namespace Task4FileParser
{
    class Program
    {
        static void Main(string[] args)
        {
            new Application(new CommandLineValidation(), new ConsoleUI()).Run(args);
        }
    }
}
