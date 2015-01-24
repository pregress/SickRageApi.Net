using Newtonsoft.Json;
using System;

namespace SickRage.Model
{
    public class Episode
    {
        public DateTime AirDate { get; set; }

        public string Description { get; set; }

        [JsonProperty(PropertyName = "file_size")]
        public int FileSize { get; set; }

        [JsonProperty(PropertyName = "file_size_human")]
        public string FileSizeHuman { get; set; }

        public string Location { get; set; }

        public string Name { get; set; }

        public string Quality { get; set; }

        [JsonProperty(PropertyName = "release_name")]
        public string ReleaseName { get; set; }

        public string Status { get; set; }

        public string Subtitles { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}