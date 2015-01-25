using SickRage.Model;
using System.Net.Http;

namespace SickRage.Services
{
    public class SickRageService
    {
        private readonly HttpClient _httpClient;

        public SickRageService()
        {
            _httpClient = new HttpClient();
        }

        public bool Ping()
        {
            const string command = "?cmd=sb.ping";

            var response = _httpClient.GetResponse<object>(command);

            return response.Result == ResponseResult.Success;
        }

        public SchedulerResult CheckScheduler()
        {
            const string command = "?cmd=sb.checkscheduler";

            return _httpClient.Get<SchedulerResult>(command);
        }

        public bool Restart()
        {
            const string command = "?cmd=sb.restart";

            var response = _httpClient.GetResponse<object>(command);

            return response.Result == ResponseResult.Success;
        }
    }
}