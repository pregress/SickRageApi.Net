namespace SickRage.Model
{
    public class DataResponse<T> : Response
    {
        public T Data { get; set; }
    }
}