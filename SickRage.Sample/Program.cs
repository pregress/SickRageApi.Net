using SickRage.Model;
using System;
using System.IO;

namespace SickRage.Sample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Create a client.
            string apiKey = "-REPLACE-BY-YOUR-API-KEY-";
            string url = "http://192.168.0.200:8083"; //Replace by your sickrage location
            var client = new Client(url, apiKey);

            //Get all shows from Sickrage.
            var shows = client.Show.GetShows();

            foreach (var show in shows)
            {
                Console.WriteLine(show);
            }

            //Get all seasonss from a specific show.
            //I.e.: Family guy: http://thetvdb.com/?tab=series&id=75978
            var seasons = client.Show.GetSeasons(75978);

            //Get episode 20 from season 4.
            var episode = seasons.GetEpisode(4, 20);
            Console.WriteLine(episode);

            //Initiate a manual search for a specific episode.
            client.Episodes.Search(new EpisodeParam
            {
                Season = 1,
                Episode = 1,
                ShowId = 75978
            });

            //Display the upcomming epsiodes for today and the near future.
            var comingEpisodes = client.ComingEpisodes.ByDate(FutureType.Today | FutureType.Soon);

            //Get the banner for a show.
            byte[] banner = client.Show.GetBanner(75978);

            using (var stream = new MemoryStream(banner))
            {
                System.Drawing.Image image = System.Drawing.Image.FromStream(stream);
            }

            //Get the poster for a show.
            byte[] poster = client.Show.GetPoster(75978);

            Console.ReadLine();
        }
    }
}