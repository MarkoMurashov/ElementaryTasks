using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileParser
{
    class UI
    {
        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static string ReadData()
        {
            return Console.ReadLine();
        }
    }
}

