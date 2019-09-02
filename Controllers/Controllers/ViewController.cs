using System;

namespace Controllers
{
    public class ViewController: IController
    {
        public string Message { get; set; }

        public ViewController(Exception ex)
        {
            Message = ex.Message;
        }

        public ViewController(string message)
        {
            Message = message;
        }

        public void ShowAnswer()
        {
            Console.WriteLine(Message);
            Saybye();
        }

        public void Show(string message="")
        {
            Console.WriteLine(Message);
        }

        public string GetDataFromConsole()
        {
            return Console.ReadLine();
        }

        public void Saybye()
        {
            Console.WriteLine("\nPress any key to continue ...");
            Console.ReadLine();
        }

    }
}
