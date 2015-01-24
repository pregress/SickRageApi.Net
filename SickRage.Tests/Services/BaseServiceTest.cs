namespace SickRage.Tests.Services
{
    public abstract class BaseServiceTest
    {
        protected Client Client { get; private set; }

        protected BaseServiceTest()
        {
            Client = new Client(AppSettings.Url, AppSettings.ApiKey);
        }
    }
}