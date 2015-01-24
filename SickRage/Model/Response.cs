namespace SickRage.Model
{
    public class Response<T>
    {
        public string Message { get; set; }

        public string Result { get; set; }

        public T Data { get; set; }
    }
}