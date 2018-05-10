using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldWriter;
using HelloWorldAPI;

namespace HelloWorldConsole
{
    class Program
    {
        private static IMessageProvider messageProviderService;
        private static MessageProviderService msgProviderService = new MessageProviderService();
        private static MessageWriter messageWriter;

        /// <summary>
        /// Client entry point.
        /// </summary>
        /// <param name="args">The console arguments.</param>
        static void Main(string[] args)
        {
            messageProviderService = msgProviderService.LocateMessageService(MsgProviderServiceType.StaticValue);
            messageWriter = MessageWriter.GetMessageWriter(ConfigurationManager.AppSettings["MessageWriter"]);

            var message = messageProviderService.GetMessage();
            messageWriter.Write(message);
        }
    }
}
