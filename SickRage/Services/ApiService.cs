using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http;

namespace SickRage.Services
{
    public class ApiService
    {
        private readonly HttpClient _client;

        public ApiService()
        {
            _client = new HttpClient();
        }

        public int GetVersion()
        {
            const string command = "?cmd=sb";

            var response = _client.GetDynamic(command);
            return (int)response.data.api_version;
        }

        public IEnumerable<string> GetApiCommands()
        {
            const string command = "?cmd=sb";

            var response = _client.GetDynamic(command);

            var array = (JArray)response.data.api_commands;

            return array.Values<string>();
        }
    }
}