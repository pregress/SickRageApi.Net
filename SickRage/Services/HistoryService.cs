using SickRage.Model;
using System.Collections.Generic;
using System.Net.Http;

namespace SickRage.Services
{
    public class HistoryService
    {
        private readonly HttpClient _client;

        public HistoryService()
        {
            _client = new HttpClient();
        }

        public IEnumerable<History> GetHistory(int limit, HistoryType type = HistoryType.Default)
        {
            const string command = "?cmd=history&limit={0}";
            const string commandType = "?cmd=history&type={0}&limit={1}";

            if (type == HistoryType.Default)
            {
                return _client.Get<IEnumerable<History>>(command, limit);
            }

            return _client.Get<IEnumerable<History>>(commandType, type.ToString().ToLowerInvariant(), limit);
        }

        public Response Trim()
        {
            const string command = "?cmd=history.trim";

            return _client.GetResponse<object>(command);
        }

        public Response Clear()
        {
            const string command = "?cmd=history.clear";

            return _client.GetResponse<object>(command);
        }
    }
}