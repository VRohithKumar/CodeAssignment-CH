namespace HelloWorldAPI.Providers
{
    /// <summary>
    /// Implementation of the <see cref="IMessageProvider"/> interface for static value.
    /// </summary>
    public class StaticValueMsgProvider : IMessageProvider
    {
        /// <summary>
        /// Return the message from a static value.
        /// </summary>
        /// <returns>Returns "Hello World".</returns>
        public string GetMessage()
        {
            return "Hello World!! ";
        }
    }
}
