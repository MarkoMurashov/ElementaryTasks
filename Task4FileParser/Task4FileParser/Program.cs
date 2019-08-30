using Assistant;
using System.IO;
using System;

using Task4FileParser.UI;
using Task4FileParser.Interfaces;

namespace Task4FileParser
{
    class Program
    {
        static void Main(string[] args)
        {
            new Application(new ValidationArgs()).Run(args);
        }
    }
}
