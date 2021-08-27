namespace Loger_app
{
    public class ErrorMesage : Message
    {
        public ErrorMesage() : base() { }

        public ErrorMesage(string error) : base(error)
        {
        }
    }
}