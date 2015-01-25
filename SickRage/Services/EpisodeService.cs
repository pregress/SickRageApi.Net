using SickRage.Model;
using System.Net.Http;

namespace SickRage.Services
{
    public class EpisodeService
    {
        private readonly HttpClient _client;

        public EpisodeService()
        {
            _client = new HttpClient();
        }

        public Episode GetEpisode(EpisodeParam episode)
        {
            const string command = "?cmd=episode&indexerid={0}&season={1}&episode={2}";

            return _client.Get<Episode>(command, episode.ShowId, episode.Season, episode.Episode);
        }

        public DataResponse<SearchResult> Search(EpisodeParam episode)
        {
            const string command = "?cmd=episode.search&indexerid={0}&season={1}&episode={2}";

            return _client.GetResponse<SearchResult>(command, episode.ShowId, episode.Season, episode.Episode);
        }

        public Response SetStatus(EpisodeParam episode, EpisodeStatus status)
        {
            const string commandSeason = "?cmd=episode.setstatus&indexerid={0}&season={1}&status={2}";
            const string commandEpisode = "?cmd=episode.setstatus&indexerid={0}&season={1}&episode={2}&status={3}";

            var statusString = ToLower(status);

            if (episode.Episode == default(int))
            {
                return _client.GetResponse<object>(commandSeason, episode.ShowId, episode.Season,
                    statusString);
            }

            return _client.GetResponse<object>(commandEpisode, episode.ShowId, episode.Season, episode.Episode,
                statusString);
        }

        private string ToLower(EpisodeStatus status)
        {
            return status.ToString().ToLowerInvariant();
        }
    }
}