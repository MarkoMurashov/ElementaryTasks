using System;

namespace Controllers
{
    public class ViewController
    {
        string _message { get; set; }

        public ViewController(Exception ex)
        {
            _message = ex.Message;
        }

        public ViewController(string message)
        {
            _message = message;
        }

        public void Show()
        {
            Console.WriteLine(_message);
            Saybye();
        }

        public void Saybye()
        {
            Console.WriteLine("\nPress any key to continue ...");
            Console.ReadLine();
        }

    }
}
