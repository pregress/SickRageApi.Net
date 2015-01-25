using SickRage.Model;
using System.Collections.Generic;
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

        public IEnumerable<Show> GetShows()
        {
            const string command = "?cmd=shows&sort=name";

            var shows = _client.Get<Dictionary<string, Show>>(command);

            return shows.Values;
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

        public byte[] GetBanner(int showId)
        {
            const string command = "?cmd=show.getbanner&indexerid=";

            return _client.GetImage(command + showId);
        }

        public byte[] GetPoster(int showId)
        {
            const string command = "?cmd=show.getposter&indexerid=";

            return _client.GetImage(command + showId);
        }

        public Response Refresh(int showId)
        {
            const string command = "?cmd=show.refresh&indexerid=";

            return _client.GetResponse<object>(command + showId);
        }

        public Response Update(int showId)
        {
            const string command = "?cmd=show.update&indexerid=";

            return _client.GetResponse<object>(command + showId);
        }

        public DataResponse<NewShow> AddNewShow(int showId)
        {
            const string command = "?cmd=show.addnew&indexerid=";

            return _client.GetResponse<NewShow>(command + showId);
        }

        public Response DeleteShow(int showId, bool removeFiles)
        {
            const string command = "?cmd=show.delete&indexerid={0}&removefiles={1}";

            return _client.GetResponse<object>(command, showId, removeFiles ? 1 : 0);
        }
    }
}