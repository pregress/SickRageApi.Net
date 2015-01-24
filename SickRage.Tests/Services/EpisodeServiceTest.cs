using Microsoft.VisualStudio.TestTools.UnitTesting;
using SickRage.Model;

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

            //Act //211751, 5, 1
            var episode = client.EpisodeService.GetEpisode(new EpisodeParam { ShowId = 211751, Season = 5, Episode = 1 });

            //Assert
            Assert.IsNotNull(episode);
            Assert.IsNotNull(episode.Name);
        }
    }
}