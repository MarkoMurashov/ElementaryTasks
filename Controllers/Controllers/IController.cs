using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public interface IController
    {
        string Message { get; set; }

        void ShowAnswer();

        void Show(string message = "");

         string GetDataFromConsole();

         void Saybye();        
    }
}
