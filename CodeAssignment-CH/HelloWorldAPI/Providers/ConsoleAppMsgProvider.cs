namespace HelloWorldAPI.Providers
{
    /// <summary>
    /// Implementation of the IMessageProvider  interface for a console application.
    /// </summary>
    public class ConsoleAppMsgProvider : IMessageProvider
    {
        /// <summary>
        /// Return the message from a console application.
        /// </summary>
        /// <returns>Returns the message from the console application.</returns>
        public string GetMessage()
        {
            return "Hello Console application";
        }
    }
}