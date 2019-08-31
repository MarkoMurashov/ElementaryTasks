using System;
using Assistant;

using Boards.ValidationControl;

namespace Boards
{
    class Program
    {
        static void Main(string[] args)
        {
            
            UI.SetConsoleColor(ConsoleColor.Black);

            new Application(new ValidationArgs()).Run(args);
       
        }
    }
}
