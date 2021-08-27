using System;

namespace Loger_app
{
    public class Message
    {
        public string DisplayMessage { get; set; }
        public Message()
        {
            DisplayMessage = string.Empty;
        }

        public Message(string message)
        {
            DisplayMessage = message;
        }

    }
}