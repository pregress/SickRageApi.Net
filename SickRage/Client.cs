using SickRage.Services;
using System;

namespace SickRage
{
    public class Client
    {
        public ApiService Api { get; private set; }

        public ShowService Show { get; private set; }

        public EpisodeService Episodes { get; private set; }

        public ComingEpisodesService ComingEpisodes { get; private set; }

        public Client(string url, string apiKey)
            : this(url, apiKey, new ApiService(), new ShowService(), new EpisodeService(), new ComingEpisodesService())
        {
        }

        internal Client(string url, string apiKey, ApiService apiService, ShowService showService, EpisodeService episodeService, ComingEpisodesService comingEpisodes)
        {
            Settings.Instance.BaseUrl = url;
            Settings.Instance.ApiKey = apiKey;

            Api = apiService;
            Show = showService;
            Episodes = episodeService;
            ComingEpisodes = comingEpisodes;
        }
    }

    internal class Settings
    {
        private const string Api = "/api/";
        private static volatile Settings instance;
        private static object syncRoot = new Object();

        private Settings()
        {
        }

        public static Settings Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Settings();
                    }
                }

                return instance;
            }
        }

        internal string BaseUrl { get; set; }

        internal string ApiKey { get; set; }

        internal string Url
        {
            get
            {
                return BaseUrl + Api + ApiKey + "/";
            }
        }
    }
}