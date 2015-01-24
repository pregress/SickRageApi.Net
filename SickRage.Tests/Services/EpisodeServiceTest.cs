using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SickRage.Tests.Services
{
    [TestClass]
    public class EpisodeServiceTest
    {
        [TestMethod]
        public void GetWorkAholicsS05E01_ReturnsEpisode()
        {
            //Arrange
            var client = new Client(AppSettings.Url, AppSettings.ApiKey);

            //Act
            var episode = client.EpisodeService.GetEpisode(211751, 5, 1);

            //Assert
            Assert.IsNotNull(episode);
            Assert.IsNotNull(episode.Name);
        }
    }
}