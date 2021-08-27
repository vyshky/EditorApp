using System;

namespace Loger_app
{
    public class Loger
    {
        public DateTime Date { get; set; }
        public string UserName { get; set; }
        public Message Message { get; set; }
        public Loger()
        {
            UserName = string.Empty;
            Message = new Message();
        }

        public Loger(DateTime date, string username, Message message)
        {
            Date = date;
            UserName = username;
            Message = message;
        }
    }
}