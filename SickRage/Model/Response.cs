using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SickRage.Model
{
    public class Response
    {
        public string Message { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ResponseResult Result { get; set; }
    }
}