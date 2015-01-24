using Microsoft.VisualStudio.TestTools.UnitTesting;
using SickRage.Model;

namespace SickRage.Tests.Services
{
    public abstract class BaseServiceTest
    {
        protected Client Client { get; private set; }

        protected BaseServiceTest()
        {
            Client = new Client(AppSettings.Url, AppSettings.ApiKey);
        }

        protected void AssertSuccess<T>(Response<T> response)
        {
            Assert.IsNotNull(response);
            Assert.AreEqual("success", response.Result);
        }
    }
}