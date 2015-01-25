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

        protected void AssertSuccess(Response response)
        {
            Assert.IsNotNull(response);
            Assert.AreEqual(ResponseResult.Success, response.Result);
        }
    }
}