namespace Learning_Angular_and_ASP.NET_Core.Services
{
    public interface IMailService
    {
        void SendMessage(string to, string subject, string body);
    }
}