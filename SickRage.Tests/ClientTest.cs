using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SickRage.Tests
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void WithHttpAndPortNoEndSlash()
        {
            //Arrange
            var client = new Client("http://192.168.0.200:8083", AppSettings.ApiKey);

            //Act
            var result = client.SickRage.Ping();

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void WithHttpAndPortEndSlash()
        {
            //Arrange
            var client = new Client("http://192.168.0.200:8083/", AppSettings.ApiKey);

            //Act
            var result = client.SickRage.Ping();

            //Assert
            Assert.IsTrue(result);
        }
    }
}