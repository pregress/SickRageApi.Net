using System;

namespace SickRage
{
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
                var baseUrl = new Uri(new Uri(BaseUrl), Api);
                return new Uri(baseUrl, ApiKey).ToString();
            }
        }
    }
}