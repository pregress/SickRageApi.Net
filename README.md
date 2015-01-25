# SickRageApi.Net   

![alt text](https://ci.appveyor.com/api/projects/status/github/prebenh/SickRageApi.Net?retina=true "Build status")

A library to consume the sickrage api from within a .net application

##Install

Install with nuget: https://www.nuget.org/packages/SickRageApi.Net/

```
PM> Install-Package SickRageApi.Net
```

## Setup
You'll need the sickrage url and api key. The api key can be found under "General configuration" => "Interface".


## Code samples

### Create a client
```C#
string apiKey = "-REPLACE-BY-YOUR-API-KEY-";
string url = "http://192.168.0.200:8083"; //Replace by your sickrage location
var client = new Client(url, apiKey);
```

### Get all shows from sickrage
```C#
var shows = client.Show.GetShows();

foreach (var show in shows)
{
    Console.WriteLine(show);
}
```

### Get all seasons from a show
You can find the show id on http://thetvdb.com

```C#
//I.e.: Family guy: http://thetvdb.com/?tab=series&id=75978
var seasons = client.Show.GetSeasons(75978);
```

### Get a specific episode from a season
```C#
var episode = seasons.GetEpisode(4, 20);
Console.WriteLine(episode);
```
### Initiate a manual search for a specific episode
```C#
 client.Episodes.Search(new EpisodeParam
   {
       Season = 1,
       Episode = 1,
       ShowId = 75978
   });
```

### Display the upcomming epsiodes for today and the near future
```C#
var comingEpisodes = client.ComingEpisodes.ByDate(FutureType.Today | FutureType.Soon);
```

### Get the banner for a show
```C#
byte[] banner = client.Show.GetBanner(75978);
using (var stream = new MemoryStream(banner))
{
    System.Drawing.Image image = System.Drawing.Image.FromStream(stream);
}
```

### Get the poster for a show
```C#
byte[] poster = client.Show.GetPoster(75978);
///...
```
