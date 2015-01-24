using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace SickRage.Tests.Services
{
    [TestClass]
    public class ShowSeviceTest : BaseServiceTest
    {
        [TestClass]
        public class GetShows : ShowSeviceTest
        {
            [TestMethod]
            public void ReturnsMoreThenOneShow()
            {
                //Act
                var shows = Client.ShowService.GetShows();

                //Assert
                Assert.IsTrue(shows.Count() > 1);
            }
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

        [TestClass]
        public class GetBanner : ShowSeviceTest
        {
            [TestMethod]
            public void GetBanner_CreateImageFromUrl()
            {
                //Arrange
                const int familyGuyId = 75978;

                //Act
                var image = Client.ShowService.GetBanner(familyGuyId);

                //Assert
                Assert.IsNotNull(image);

                image.Dispose();
            }
        }

        [TestClass]
        public class GetPoster : ShowSeviceTest
        {
            [TestMethod]
            public void GetPoster_CreateImageFromUrl()
            {
                //Arrange
                const int familyGuyId = 75978;

                //Act
                var image = Client.ShowService.GetPoster(familyGuyId);

                //Assert
                Assert.IsNotNull(image);

                image.Dispose();
            }
        }

        [TestClass]
        public class Refresh : ShowSeviceTest
        {
            [TestMethod]
            public void Returns_Success()
            {
                //Arrange
                const int familyGuyId = 75978;

                //Act
                var response = Client.ShowService.Refresh(familyGuyId);

                //Assert
                AssertSuccess(response);
            }
        }

        [TestClass]
        public class Update : ShowSeviceTest
        {
            [TestMethod]
            public void Returns_Success()
            {
                //Arrange
                const int familyGuyId = 75978;

                //Act
                var response = Client.ShowService.Update(familyGuyId);

                //Assert
                AssertSuccess(response);
            }
        }
    }
}