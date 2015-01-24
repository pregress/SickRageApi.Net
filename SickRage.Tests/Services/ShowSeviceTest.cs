using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace SickRage.Tests.Services
{
    [TestClass]
    public class ShowSeviceTest
    {
        protected Client Client { get; private set; }

        public ShowSeviceTest()
        {
            Client = new Client(AppSettings.Url, AppSettings.ApiKey);
        }

        [TestClass]
        public class GetShow : ShowSeviceTest
        {
            [TestMethod]
            public void GetGameOfThrones_ReturnsShow()
            {
                //Arrange
                const int gameOfThronesId = 121361;

                //Act
                var show = Client.ShowService.GetShow(gameOfThronesId);

                //Assert
                Assert.IsNotNull(show);
                Assert.IsNotNull(show.Name);
            }
        }

        [TestClass]
        public class GetSeasons : ShowSeviceTest
        {
            [TestMethod]
            public void GetSeasons_ReturnsListOfSeasonsAndEpisodes()
            {
                //Arrange
                const int familyGuyId = 75978;

                //Act
                var seasons = Client.ShowService.GetSeasons(familyGuyId);

                //Assert
                Assert.IsNotNull(seasons);
                Assert.IsTrue(seasons.Count > 0);
                Assert.IsNotNull(seasons.First().Value.Count > 0);
            }
        }

        [TestClass]
        public class GetStats : ShowSeviceTest
        {
            [TestMethod]
            public void GetStats_ReturnsStatistics()
            {
                //Arrange

                const int familyGuyId = 75978;

                //Act
                var statistics = Client.ShowService.GetStats(familyGuyId);

                //Assert
                Assert.IsNotNull(statistics);
                Assert.AreNotEqual(0, statistics.Total);
            }
        }
    }
}