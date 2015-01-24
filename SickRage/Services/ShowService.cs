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

        public Show GetShow(int showId)
        {
            const string command = "?cmd=show&tvdbid=";

            return _client.Get<Show>(command + showId);
        }

        public SeasonList GetSeasons(int showId)
        {
            const string command = "?cmd=show.seasons&indexerid=";

            return _client.Get<SeasonList>(command + showId);
        }

        public ShowStats GetStats(int showId)
        {
            const string command = "?cmd=show.stats&indexerid=";

            return _client.Get<ShowStats>(command + showId);
        }
    }
}