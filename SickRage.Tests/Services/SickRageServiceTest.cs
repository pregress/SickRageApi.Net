using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SickRage.Tests.Services
{
    [TestClass]
    public class SickRageServiceTest : BaseServiceTest
    {
        [TestClass]
        public class Ping : SickRageServiceTest
        {
            [TestMethod]
            public void ReturnsTrue()
            {
                //Act
                var result = Client.SickRage.Ping();

                //Assert
                Assert.IsTrue(result);
            }
        }

        [TestClass]
        public class CheckScheduler : SickRageServiceTest
        {
            [TestMethod]
            public void ReturnsShedulerResult()
            {
                //Act
                var result = Client.SickRage.CheckScheduler();

                //Assert
                Assert.IsNotNull(result);
            }
        }

        [TestClass]
        public class Restart : SickRageServiceTest
        {
            [TestMethod]
            public void ReturnsTrue()
            {
                //Act
                var result = Client.SickRage.Restart();

                //Assert
                Assert.IsTrue(result);
            }
        }
    }
}