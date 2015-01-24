using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace SickRage.Tests.Services
{
    [TestClass]
    public class ApiServiceTest
    {
        [TestMethod]
        public void GetVersion_ReturnsFive()
        {
            //Arrange
            var client = new Client(AppSettings.Url, AppSettings.ApiKey);

            //Act
            var version = client.Api.GetVersion();

            //Assert
            Assert.AreEqual(5, version);
        }

        [TestMethod]
        public void GetApiCommands_ReturnsMoreThenOneElement()
        {
            //Arrange
            var client = new Client(AppSettings.Url, AppSettings.ApiKey);

            //Act
            var commands = client.Api.GetApiCommands();

            //Assert
            Assert.IsTrue(commands.Count() > 1);

            Console.WriteLine("All commands: {0}{1}", Environment.NewLine, string.Join(Environment.NewLine, commands));
        }
    }
}