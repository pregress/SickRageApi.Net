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
