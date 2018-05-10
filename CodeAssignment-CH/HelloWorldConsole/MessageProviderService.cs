using HelloWorldAPI;
using HelloWorldAPI.Providers;

namespace HelloWorldConsole
{
    /// <summary>
    /// Service locator for the <see cref="IMessageProvider"/> interface.
    /// </summary>
    public class MessageProviderService
    {
        /// <summary>
        /// Return the desired <see cref="IMessageProvider"/> implementation. 
        /// </summary>
        /// <param name="messageService">The type of message service required.</param>
        /// <returns>A <see cref="IMessageProvider"/> implementation.</returns>
        public IMessageProvider LocateMessageService(MsgProviderServiceType messageService)
        {
            switch (messageService)
            {
                case MsgProviderServiceType.StaticValue:
                    return new StaticValueMsgProvider();
                case MsgProviderServiceType.MobileApplication:
                    return new MobileAppMsgProvider();
                case MsgProviderServiceType.WebApplication:
                    return new WebAppMsgProvider();
                case MsgProviderServiceType.ConsoleApplication:
                    return new ConsoleAppMsgProvider();
                case MsgProviderServiceType.WindowsService:
                    return new WindowsServiceMsgProvider();
                default:
                    return new StaticValueMsgProvider();
            }
        }
    }

    /// <summary>
    /// <see cref="IMessageProvider"/> implementations enum.
    /// </summary>
    public enum MsgProviderServiceType
    {
        StaticValue,
        MobileApplication,
        WebApplication,
        ConsoleApplication,
        WindowsService
    }
}
