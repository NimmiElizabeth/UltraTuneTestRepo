namespace SampleWebApplication.DependencyInjection
{
    public class MessageService : IMessageService
    {
        public string GetMessage(string text)
        {
            return text + " from DependencyInjection demo";
        }
    }
}
