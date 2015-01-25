using Microsoft.VisualStudio.TestTools.UnitTesting;
using SickRage.Model;

namespace SickRage.Tests.Services
{
    [TestClass]
    public class ComingEpisodesServiceTest : BaseServiceTest
    {
        [TestClass]
        public class ByDate : ComingEpisodesServiceTest
        {
            [TestMethod]
            public void ReturnsEpisodes()
            {
                //Act
                var comingEpisodes = Client.ComingEpisodes.ByDate();

                //Assert
                Assert.IsTrue(comingEpisodes.Count > 0);
            }

            [TestMethod]
            public void ReturnsAllTypes()
            {
                //Act
                var comingEpisodes = Client.ComingEpisodes.ByDate();

                //Assert
                Assert.IsTrue(comingEpisodes.ContainsKey(FutureType.Later));
                Assert.IsTrue(comingEpisodes.ContainsKey(FutureType.Missed));
                Assert.IsTrue(comingEpisodes.ContainsKey(FutureType.Soon));
                Assert.IsTrue(comingEpisodes.ContainsKey(FutureType.Today));
            }

            [TestMethod]
            public void WithSoon_OnlyReturnsSoon()
            {
                //Act
                var comingEpisodes = Client.ComingEpisodes.ByDate(FutureType.Soon);

                //Assert
                Assert.IsTrue(comingEpisodes.ContainsKey(FutureType.Soon));
                Assert.IsFalse(comingEpisodes.ContainsKey(FutureType.Missed));
                Assert.IsFalse(comingEpisodes.ContainsKey(FutureType.Later));
                Assert.IsFalse(comingEpisodes.ContainsKey(FutureType.Today));
            }

            [TestMethod]
            public void WithMissedAndToday_ReturnsTwo()
            {
                //Act
                var comingEpisodes = Client.ComingEpisodes.ByDate(FutureType.Missed | FutureType.Today);

                //Assert
                Assert.AreEqual(2, comingEpisodes.Count);
            }

            [TestMethod]
            public void WithMissedTodayAndSoon_ReturnsThree()
            {
                //Act
                var comingEpisodes = Client.ComingEpisodes.ByDate(FutureType.Missed | FutureType.Today | FutureType.Soon);

                //Assert
                Assert.AreEqual(3, comingEpisodes.Count);
            }
        }

        [TestClass]
        public class ByNetwork : ComingEpisodesServiceTest
        {
            [TestMethod]
            public void ReturnsEpisodes()
            {
                //Act
                var comingEpisodes = Client.ComingEpisodes.ByNetwork();

                //Assert
                Assert.IsTrue(comingEpisodes.Count > 0);
            }

            [TestMethod]
            public void WithLater_OnlyReturnsLater()
            {
                //Act
                var comingEpisodes = Client.ComingEpisodes.ByDate(FutureType.Later);

                //Assert
                Assert.IsTrue(comingEpisodes.ContainsKey(FutureType.Later));
                Assert.IsFalse(comingEpisodes.ContainsKey(FutureType.Missed));
                Assert.IsFalse(comingEpisodes.ContainsKey(FutureType.Soon));
                Assert.IsFalse(comingEpisodes.ContainsKey(FutureType.Today));
            }
        }

        [TestClass]
        public class ByShowName : ComingEpisodesServiceTest
        {
            [TestMethod]
            public void ReturnsEpisodes()
            {
                //Act
                var comingEpisodes = Client.ComingEpisodes.ByShowName();

                //Assert
                Assert.IsTrue(comingEpisodes.Count > 0);
            }

            [TestMethod]
            public void WithMissed_OnlyReturnsMissed()
            {
                //Act
                var comingEpisodes = Client.ComingEpisodes.ByDate(FutureType.Missed);

                //Assert
                Assert.IsTrue(comingEpisodes.ContainsKey(FutureType.Missed));
                Assert.IsFalse(comingEpisodes.ContainsKey(FutureType.Later));
                Assert.IsFalse(comingEpisodes.ContainsKey(FutureType.Soon));
                Assert.IsFalse(comingEpisodes.ContainsKey(FutureType.Today));
            }
        }
    }
}