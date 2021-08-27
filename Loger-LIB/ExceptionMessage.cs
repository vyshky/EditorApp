namespace Loger_app
{
    public class ExceptionMessage : Message
    {
        public ExceptionMessage() : base() { }

        public ExceptionMessage(string exception) : base(exception)
        {
        }
    }
}