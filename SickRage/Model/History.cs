using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace SickRage.Model
{
    public class History
    {
        public DateTime Date { get; set; }

        public int Episode { get; set; }

        [JsonProperty(PropertyName = "indexerid")]
        public int Id { get; set; }

        public string Quality { get; set; }

        public string Resource { get; set; }

        [JsonProperty(PropertyName = "resource_path")]
        public string ResourcePath { get; set; }

        public int Season { get; set; }

        [JsonProperty(PropertyName = "show_name")]
        public string ShowName { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public HistoryType Status { get; set; }

        public int TvdbId { get; set; }

        public int Version { get; set; }
    }
}