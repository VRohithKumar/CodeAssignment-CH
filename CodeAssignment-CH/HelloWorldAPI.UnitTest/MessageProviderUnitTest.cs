using System;
using HelloWorldAPI.Providers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldAPI.UnitTest
{
    [TestClass]
    public class MessageProviderUnitTest
    {
        private static IMessageProvider messageProvider;
        private static string message;
      

        [TestMethod]
        public void ConsoleAppMsgProviderTest()
        {
            //arrange
            string expectedResult = "Hello Console application";

            //act
            messageProvider = new ConsoleAppMsgProvider();
            message = messageProvider.GetMessage();
            
            //assert
            Assert.AreEqual(expectedResult, message);
        }

        [TestMethod]
        public void MobileAppMsgProvider()
        {
            //arrange
            string expectedResult = "Hello Mobile application";

            //act
            messageProvider = new MobileAppMsgProvider();
            message = messageProvider.GetMessage();
            
            //assert
            Assert.AreEqual(expectedResult, message);
        }

        [TestMethod]
        public void StaticValueMsgProvider()
        {
            //arrange
            string expectedResult = "Hello World!! ";

            //act
            messageProvider = new StaticValueMsgProvider();
            message = messageProvider.GetMessage();

            //assert
            Assert.AreEqual(expectedResult, message);
        }

        [TestMethod]
        public void WebAppMsgProvider()
        {
            //arrange
            string expectedResult = "Hello Web Application";

            //act
            messageProvider = new WebAppMsgProvider();
            message = messageProvider.GetMessage();

            //assert
            Assert.AreEqual(expectedResult, message);
        }

        [TestMethod]
        public void WindowsServiceMsgProvider()
        {
            //arrange
            string expectedResult = "Hello Window Service Application";

            //act
            messageProvider = new WindowsServiceMsgProvider();
            message = messageProvider.GetMessage();

            //assert
            Assert.AreEqual(expectedResult, message);
        }
    }
}
