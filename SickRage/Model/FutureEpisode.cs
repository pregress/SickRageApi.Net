using Newtonsoft.Json;
using System;

namespace SickRage.Model
{
    public class FutureEpisode
    {
        public DateTime AirDate { get; set; }

        public string Airs { get; set; }

        [JsonProperty(PropertyName = "ep_name")]
        public string EpisodeName { get; set; }

        [JsonProperty(PropertyName = "ep_plot")]
        public string EpisodePlot { get; set; }

        public int Episode { get; set; }

        [JsonProperty(PropertyName = "indexerid")]
        public int Id { get; set; }

        public string Network { get; set; }

        public bool Paused { get; set; }

        public string Quality { get; set; }

        public int Season { get; set; }

        [JsonProperty(PropertyName = "show_name")]
        public string ShowName { get; set; }

        [JsonProperty(PropertyName = "show_status")]
        public string ShowStatus { get; set; }

        public int TvdbId { get; set; }

        public DayOfWeek WeekDay { get; set; }
    }
}