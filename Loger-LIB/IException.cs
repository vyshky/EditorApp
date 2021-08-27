namespace Loger_app
{
    public class IException : InterfaceMessage
    {
        public Message CreateMessage()
        {
            return new ErrorMesage("Exception!");
        }

        public Message CreateMessage(string message)
        {
            return new ErrorMesage(message);
        }
    }
}