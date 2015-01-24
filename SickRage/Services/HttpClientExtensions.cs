using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SickRage.Model;

namespace SickRage.Services
{
    public static class HttpClientExtensions
    {
        public static dynamic GetDynamic(this HttpClient client, string command)
        {
            var task = client.GetDynamicAsync(command);
            task.Wait();

            return task.Result;
        }

        public static async Task<dynamic> GetDynamicAsync(this HttpClient client, string command)
        {
            var response = await client.GetAsync(Settings.Instance.Url + command);
            AdjustContentType(response);

            var jsonString = await response.Content.ReadAsStringAsync();

            return JObject.Parse(jsonString);
        }

        public static async Task<T> GetAsync<T>(this HttpClient client, string command)
        {
            var response = await client.GetAsync(Settings.Instance.Url + command);
            AdjustContentType(response);

            var jsonString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Response<T>>(jsonString).Data;
        }

        public static T Get<T>(this HttpClient client, string command)
        {
            var task = client.GetAsync<T>(command);
            task.Wait();

            return task.Result;
        }

        public static T Get<T>(this HttpClient client, string command, params object[] parameters)
        {
            var task = client.GetAsync<T>(string.Format(command, parameters));
            task.Wait();

            return task.Result;
        }

        private static void AdjustContentType(HttpResponseMessage response)
        {
            response.Content.Headers.ContentType.CharSet = "UTF-8";
        }
    }
}