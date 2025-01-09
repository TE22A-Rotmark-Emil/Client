using System.Net.Http.Json;

HttpClient client = new();

client.BaseAddress = new("https://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/16.158/lat/58.5812/data.json");

int randomNumber = Random.Shared.Next(200)+1; // there is no pokemon #0

Console.WriteLine("Ok write a longitude");
int longitude = int.Parse(Console.ReadLine());

Console.WriteLine("Ok type a latitude");
int latitude = int.Parse(Console.ReadLine());

HttpResponseMessage response = client.GetAsync("").Result;

// Pokemon e = response.Content.ReadFromJsonAsync<Pokemon>().Result;

string result = response.Content.ReadAsStringAsync().Result;

File.WriteAllText("result.json", result);

Console.WriteLine(result);

Console.ReadLine();