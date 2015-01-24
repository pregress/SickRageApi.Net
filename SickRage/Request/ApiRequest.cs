namespace SickRage.Request
{
    internal class ApiRequest
    {
        public string Url { get; set; }

        public string Method { get; set; }

        public string ContentType { get; set; }

        public ApiRequest()
        {
            Method = "GET";
            ContentType = "application/json";
        }
    }
}