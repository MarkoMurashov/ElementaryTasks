using System;

namespace FibonacciSequence
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
