using SickRage.Model;
using System.Collections.Generic;
using System.Net.Http;

namespace SickRage.Services
{
    public class ComingEpisodesService
    {
        private readonly HttpClient _client;

        public ComingEpisodesService()
        {
            _client = new HttpClient();
        }

        public Dictionary<FutureType, List<FutureEpisode>> ByDate(FutureType types = FutureType.Missed | FutureType.Today | FutureType.Soon | FutureType.Later)
        {
            const string command = "?cmd=future&sort=date&type={0}";

            var typestring = MakeTypeParameter(types);

            return _client.Get<Dictionary<FutureType, List<FutureEpisode>>>(command, typestring);
        }

        public Dictionary<FutureType, List<FutureEpisode>> ByNetwork(FutureType types = FutureType.Missed | FutureType.Today | FutureType.Soon | FutureType.Later)
        {
            const string command = "?cmd=future&sort=network&type={0}";

            var typestring = MakeTypeParameter(types);

            return _client.Get<Dictionary<FutureType, List<FutureEpisode>>>(command, typestring);
        }

        public Dictionary<FutureType, List<FutureEpisode>> ByShowName(FutureType types = FutureType.Missed | FutureType.Today | FutureType.Soon | FutureType.Later)
        {
            const string command = "?cmd=future&sort=show&type={0}";

            var typestring = MakeTypeParameter(types);

            return _client.Get<Dictionary<FutureType, List<FutureEpisode>>>(command, typestring);
        }

        private string MakeTypeParameter(FutureType types)
        {
            var typestring = types.ToString().Replace(", ", "|").ToLowerInvariant();
            return typestring;
        }
    }
}