using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace SickRage.Model
{
    public class Show
    {
        public int TvdbId { get; set; }

        [JsonProperty(PropertyName = "show_name")]
        public string Name { get; set; }

        public bool Paused { get; set; }

        public string Language { get; set; }

        [JsonProperty(PropertyName = "next_ep_airdate")]
        public DateTime? NextEpisodeAirdate { get; set; }

        [JsonProperty(PropertyName = "season_list")]
        public List<int> Seasons { get; set; }

        public List<string> Genre { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ShowStatus Status { get; set; }

        public string Location { get; set; }

        public string Network { get; set; }

        public string Quality { get; set; }

        public string Airs { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}