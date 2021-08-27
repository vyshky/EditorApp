namespace Loger_app
{
    public class IInfo
    {
        public Message CreateMessage()
        {
            return new ErrorMesage("информационное сообщение!");
        }

        public Message CreateMessage(string message)
        {
            return new ErrorMesage(message);
        }
    }
}