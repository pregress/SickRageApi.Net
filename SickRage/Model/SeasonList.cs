using System.Collections.Generic;

namespace SickRage.Model
{
    public class SeasonList : Dictionary<int, Dictionary<int, SeasonEpisode>>
    {
        public SeasonEpisode GetEpisode(int season, int episode)
        {
            return this[season][episode];
        }
    }
}