using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SickRage.Tests.Services
{
    [TestClass]
    public class ShowSeviceTest
    {
        [TestMethod]
        public void GetGameOfThrones_ReturnsShow()
        {
            //Arrange
            var client = new Client(AppSettings.Url, AppSettings.ApiKey);

            //Act
            var show = client.ShowService.GetShow(121361);

            //Assert
            Assert.IsNotNull(show);
            Assert.IsNotNull(show.Name);
        }
    }
}