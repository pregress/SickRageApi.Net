using Microsoft.VisualStudio.TestTools.UnitTesting;
using SickRage.Model;
using System.Linq;

namespace SickRage.Tests.Services
{
    [TestClass]
    public class ShowServiceTest : BaseServiceTest
    {
        [TestClass]
        public class GetShows : ShowServiceTest
        {
            [TestMethod]
            public void ReturnsMoreThenOneShow()
            {
                //Act
                var shows = Client.Show.GetShows();

                //Assert
                Assert.IsTrue(shows.Count() > 1);
            }
        }

        [TestClass]
        public class GetShow : ShowServiceTest
        {
            [TestMethod]
            public void GetGameOfThrones_ReturnsShow()
            {
                //Arrange
                const int gameOfThronesId = 121361;

                //Act
                var show = Client.Show.GetShow(gameOfThronesId);

                //Assert
                Assert.IsNotNull(show);
                Assert.IsNotNull(show.Name);
            }
        }

        [TestClass]
        public class GetSeasons : ShowServiceTest
        {
            [TestMethod]
            public void GetSeasons_ReturnsListOfSeasonsAndEpisodes()
            {
                //Arrange
                const int familyGuyId = 75978;

                //Act
                var seasons = Client.Show.GetSeasons(familyGuyId);

                //Assert
                Assert.IsNotNull(seasons);
                Assert.IsTrue(seasons.Count > 0);
                Assert.IsNotNull(seasons.First().Value.Count > 0);
            }
        }

        [TestClass]
        public class GetStats : ShowServiceTest
        {
            [TestMethod]
            public void GetStats_ReturnsStatistics()
            {
                //Arrange
                const int familyGuyId = 75978;

                //Act
                var statistics = Client.Show.GetStats(familyGuyId);

                //Assert
                Assert.IsNotNull(statistics);
                Assert.AreNotEqual(0, statistics.Total);
            }
        }

        [TestClass]
        public class GetBanner : ShowServiceTest
        {
            [TestMethod]
            public void GetBanner_CreateImageFromUrl()
            {
                //Arrange
                const int familyGuyId = 75978;

                //Act
                var image = Client.Show.GetBanner(familyGuyId);

                //Assert
                Assert.IsNotNull(image);
                Assert.IsTrue(image.Length > 0);
            }
        }

        [TestClass]
        public class GetPoster : ShowServiceTest
        {
            [TestMethod]
            public void GetPoster_CreateImageFromUrl()
            {
                //Arrange
                const int familyGuyId = 75978;

                //Act
                var image = Client.Show.GetPoster(familyGuyId);

                //Assert
                Assert.IsNotNull(image);
                Assert.IsTrue(image.Length > 0);
            }
        }

        [TestClass]
        public class Refresh : ShowServiceTest
        {
            [TestMethod]
            public void Returns_Success()
            {
                //Arrange
                const int familyGuyId = 75978;

                //Act
                var response = Client.Show.Refresh(familyGuyId);

                //Assert
                AssertSuccess(response);
            }
        }

        [TestClass]
        public class Update : ShowServiceTest
        {
            [TestMethod]
            public void Returns_Success()
            {
                //Arrange
                const int topGearId = 74608;

                //Act
                var response = Client.Show.Update(topGearId);

                //Assert
                AssertSuccess(response);
            }
        }

        [TestClass]
        public class AddNewShow : ShowServiceTest
        {
            [TestMethod]
            public void AddBanshee_ReturnsSuccess()
            {
                //Arrange
                //http://thetvdb.com/?id=259765&tab=series
                const int bansheeId = 259765;

                //Act
                var response = Client.Show.AddNewShow(bansheeId);

                //Assert
                Assert.AreEqual(ResponseResult.Success, response.Result);
                Assert.IsNotNull(response.Data.Name);
            }
        }

        [TestClass]
        public class DeleteShow : ShowServiceTest
        {
            [TestMethod]
            public void DeleteBanshee_ReturnsSuccess()
            {
                //Arrange
                const int bansheeId = 259765;

                //Act
                var response = Client.Show.DeleteShow(bansheeId, false);

                //Assert
                Assert.AreEqual(ResponseResult.Success, response.Result);
            }
        }
    }
}