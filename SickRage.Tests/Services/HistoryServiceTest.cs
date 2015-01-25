using Microsoft.VisualStudio.TestTools.UnitTesting;
using SickRage.Model;
using System.Linq;

namespace SickRage.Tests.Services
{
    [TestClass]
    public class HistoryServiceTest : BaseServiceTest
    {
        [TestClass]
        public class GetHistory : HistoryServiceTest
        {
            [TestMethod]
            public void WithTenLimit_ReturnsTenElements()
            {
                //Act
                var results = Client.History.GetHistory(10);

                //Assert
                Assert.AreEqual(10, results.Count());
            }

            [TestMethod]
            public void WithSnatchedAndLimit_ReturnsOnlySnatched()
            {
                //Act
                var results = Client.History.GetHistory(10, HistoryType.Snatched);

                //Assert
                Assert.IsTrue(results.All(h => h.Status == HistoryType.Snatched));
            }
        }

        [TestClass]
        public class Trim : HistoryServiceTest
        {
            [TestMethod]
            public void ReturnsSuccess()
            {
                //Act
                var result = Client.History.Trim();

                //Assert
                AssertSuccess(result);
            }
        }

        [TestClass]
        public class Clear : HistoryServiceTest
        {
            [TestMethod]
            public void ReturnsSuccess()
            {
                //Act
                var result = Client.History.Clear();

                //Assert
                AssertSuccess(result);
            }
        }
    }
}