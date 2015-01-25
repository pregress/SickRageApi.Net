using SickRage.Services;

namespace SickRage
{
    public class Client
    {
        public ApiService Api { get; private set; }

        public ShowService Show { get; private set; }

        public EpisodeService Episodes { get; private set; }

        public ComingEpisodesService ComingEpisodes { get; private set; }

        public SickRageService SickRage { get; private set; }

        public HistoryService History { get; private set; }

        public Client(string url, string apiKey)
            : this(url, apiKey, new ApiService(), new ShowService(), new EpisodeService(), new ComingEpisodesService(),
            new SickRageService(), new HistoryService())
        {
        }

        internal Client(string url, string apiKey, ApiService apiService, ShowService showService,
            EpisodeService episodeService, ComingEpisodesService comingEpisodes, SickRageService sickRageService,
            HistoryService history)
        {
            Settings.Instance.BaseUrl = url;
            Settings.Instance.ApiKey = apiKey;

            Api = apiService;
            Show = showService;
            Episodes = episodeService;
            ComingEpisodes = comingEpisodes;
            SickRage = sickRageService;
            History = history;
        }
    }
}