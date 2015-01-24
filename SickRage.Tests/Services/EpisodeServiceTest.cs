using Microsoft.VisualStudio.TestTools.UnitTesting;
using SickRage.Model;

namespace SickRage.Tests.Services
{
    [TestClass]
    public class EpisodeServiceTest : BaseServiceTest
    {
        [TestClass]
        public class GetEpisode : EpisodeServiceTest
        {
            [TestMethod]
            public void GetWorkAholicsS05E01_ReturnsEpisode()
            {
                //Arrange
                var episodeParameter = new EpisodeParam { ShowId = 211751, Season = 5, Episode = 1 };

                //Act
                var episode = Client.Episodes.GetEpisode(episodeParameter);

                //Assert
                Assert.IsNotNull(episode);
                Assert.IsNotNull(episode.Name);
            }
        }

        [TestClass]
        public class Search : EpisodeServiceTest
        {
            [TestMethod]
            public void Returns_Failure()
            {
                //Arrange
                var episodeParameter = new EpisodeParam { ShowId = 75978, Season = 0, Episode = 20 };

                //Act
                var response = Client.Episodes.Search(episodeParameter);

                //Assert
                Assert.IsNotNull(response);
                Assert.AreEqual("failure", response.Result);
            }

            [TestMethod, Ignore] //Ignored triggers a new download
            public void Returns_Succes()
            {
                //Arrange
                var episodeParameter = new EpisodeParam { ShowId = 263365, Season = 1, Episode = 1 };

                //Act
                var response = Client.Episodes.Search(episodeParameter);

                //Assert
                AssertSuccess(response);
            }
        }
    }
}