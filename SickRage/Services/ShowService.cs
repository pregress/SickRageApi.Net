using SickRage.Model;
using System.Net.Http;

namespace SickRage.Services
{
    public class ShowService
    {
        private readonly HttpClient _client;

        public ShowService()
        {
            _client = new HttpClient();
        }

        public Show GetShow(int id)
        {
            const string command = "?cmd=show&tvdbid=";

            return _client.Get<Show>(command + id);
        }
    }
}