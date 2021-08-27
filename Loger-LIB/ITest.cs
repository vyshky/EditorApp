namespace Loger_app
{
    public class ITest : InterfaceMessage
    {
        public Message CreateMessage()
        {
            return new ErrorMesage("Test!");
        }

        public Message CreateMessage(string message)
        {
            return new ErrorMesage(message);
        }
    }
}