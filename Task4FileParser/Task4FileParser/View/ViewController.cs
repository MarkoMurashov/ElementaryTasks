using System;

namespace Task4FileParser.UI
{
    class ViewController: IDisplay
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
            Assistant.UI.ShowMessage(_message);
            Assistant.UI.Saybye();
        }
    }
}
