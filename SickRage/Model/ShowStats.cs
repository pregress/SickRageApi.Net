using Newtonsoft.Json;

namespace SickRage.Model
{
    public class ShowStats
    {
        public int Archived { get; set; }

        public int Failed { get; set; }

        public int Ignored { get; set; }

        public int Skipped { get; set; }

        public int Subtiteld { get; set; }

        public int Total { get; set; }

        public int Unaired { get; set; }

        public int Wanted { get; set; }

        public QualityStats Downloaded { get; set; }

        public QualityStats Snatched { get; set; }
    }

    public class QualityStats
    {
        [JsonProperty(PropertyName = "1080p_bluray")]
        public int Bluray1080p { get; set; }

        [JsonProperty(PropertyName = "1080p_hd_tv")]
        public int HdTv1080p { get; set; }

        [JsonProperty(PropertyName = "1080p_web")]
        public int WebDl1080p { get; set; }

        [JsonProperty(PropertyName = "720p_bluray")]
        public int Bluray720p { get; set; }

        [JsonProperty(PropertyName = "720p_web")]
        public int WebDl720p { get; set; }

        [JsonProperty(PropertyName = "hd_tv")]
        public int HdTv { get; set; }

        [JsonProperty(PropertyName = "rawhd_tv")]
        public int RawHdTv { get; set; }

        [JsonProperty(PropertyName = "sd_dvd")]
        public int SdDvd { get; set; }

        [JsonProperty(PropertyName = "sd_tv")]
        public int SdTv { get; set; }

        public int Total { get; set; }

        public int Unknow { get; set; }
    }
}