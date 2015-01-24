using SickRage.Services;
using System;

namespace SickRage
{
    public class Client
    {
        public ApiService ApiService { get; private set; }

        public ShowService ShowService { get; private set; }

        public EpisodeService EpisodeService { get; private set; }

        public Client(string url, string apiKey)
            : this(url, apiKey, new ApiService(), new ShowService(), new EpisodeService())
        {
        }

        internal Client(string url, string apiKey, ApiService apiService, ShowService showService, EpisodeService episodeService)
        {
            Settings.Instance.BaseUrl = url;
            Settings.Instance.ApiKey = apiKey;

            ApiService = apiService;
            ShowService = showService;
            EpisodeService = episodeService;
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