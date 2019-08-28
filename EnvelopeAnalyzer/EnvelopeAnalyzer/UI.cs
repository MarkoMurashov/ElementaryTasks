using System;

namespace EnvelopeAnalyzer
{
    class UI
    {
        public static void ShowAnswer(bool answer)
        {
            if (answer)
            {
                Console.WriteLine(Settings.ANSWER_YES);
            }
            else
            {
                Console.WriteLine(Settings.ANSWER_NO);
            }
        }

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
