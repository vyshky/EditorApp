namespace Loger_app
{
    public class IWarning : InterfaceMessage
    {
        public Message CreateMessage()
        {
            return new ErrorMesage("Warning!");
        }

        public Message CreateMessage(string message)
        {
            return new ErrorMesage(message);
        }
    }
}