# SickRageApi.Net   

![alt text](https://ci.appveyor.com/api/projects/status/github/prebenh/SickRageApi.Net?retina=true "Build status")

A library to consume the sickrage api from within a .net application

## Setup
You'll need the sickrage url and api key. The api key can be found under "General configuration" => "Interface".


## Code samples

You can have a look in the sample project, or in the unit test project.

```C#
string apiKey = "-REPLACE-BY-YOUR-API-KEY-";
string url = "http://192.168.0.200:8083"; //Replace by your sickrage location
var client = new Client(url, apiKey);

var shows = client.Show.GetShows();

foreach (var show in shows)
{
   Console.WriteLine(show);
}

Console.ReadLine();
```
