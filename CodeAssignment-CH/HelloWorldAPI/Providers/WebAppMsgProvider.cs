namespace HelloWorldAPI.Providers
{
    /// <summary>
    /// Implementation of the IMessageProvider interface for a web application.
    /// </summary>
    public class WebAppMsgProvider : IMessageProvider
    {
        /// <summary>
        /// Return the message from a web application.
        /// </summary>
        /// <returns>Returns the message from the web application.</returns>
        public string GetMessage()
        {
            return "Hello Web Application";
        }
    }
}