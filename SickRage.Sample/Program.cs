using System;

namespace SickRage.Sample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string apiKey = "-REPLACE-BY-YOUR-API-KEY-";
            string url = "http://192.168.0.200:8083"; //Replace by your sickrage location
            var client = new Client(url, apiKey);

            var shows = client.Show.GetShows();

            foreach (var show in shows)
            {
                Console.WriteLine(show);
            }

            Console.ReadLine();
        }
    }
}