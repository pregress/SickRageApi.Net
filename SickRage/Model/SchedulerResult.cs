using Newtonsoft.Json;
using System;

namespace SickRage.Model
{
    public class SchedulerResult
    {
        [JsonProperty(PropertyName = "backlog_is_paused")]
        public bool BacklogIsPaused { get; set; }

        [JsonProperty(PropertyName = "backlog_is_running")]
        public bool BacklogIsRunning { get; set; }

        [JsonProperty(PropertyName = "last_backlog")]
        public DateTime LastBacklog { get; set; }

        [JsonProperty(PropertyName = "next_backlog")]
        public DateTime NextBacklog { get; set; }
    }
}