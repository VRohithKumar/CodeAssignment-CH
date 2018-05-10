namespace HelloWorldAPI.Providers
{
    /// <summary>
    /// Implementation of the IMessageProvider interface for a mobile application.
    /// </summary>
    public class MobileAppMsgProvider : IMessageProvider
    {
        /// <summary>
        /// Return the message from a mobile application.
        /// </summary>
        /// <returns>Returns the message from the mobile application.</returns>
        public string GetMessage()
        {
            return "Hello Mobile application";
        }
    }
}