﻿using System;

namespace FileParser.UI
{
    class ResultController: IDisplay
    {
        string _message { get; set; }

        public ResultController(Exception ex)
        {
            _message = ex.Message;
        }

        public ResultController(string message)
        {
            _message = message;
        }

        public void Show()
        {            
            Assistant.UI.ShowMessageWithNewLine(_message);
            Assistant.Helper.Saybye();
        }
    }
}