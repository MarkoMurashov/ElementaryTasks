using Assistant;
using System.IO;
using System;

using FileParser.UI;
using FileParser.Interfaces;

namespace FileParser
{
    class Program
    {
        static void Main(string[] args)
        {
            new Application(new ValidationArgs()).Run(args);
        }
    }
}
