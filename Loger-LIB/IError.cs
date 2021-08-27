namespace Loger_app
{
    public class IError : InterfaceMessage
    {
        public Message CreateMessage()
        {
            return new ErrorMesage("Error!");
        }

        public Message CreateMessage(string message)
        {
            return new ErrorMesage(message);
        }
    }
}