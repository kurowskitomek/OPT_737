using OPTCore.AirfieldsData.Models;
using OPTCore.WeatherData.Models;
using System.Net.Http.Headers;

namespace OPTCore.WeatherData
{
    public class WeatherService : IWeatherService
    {
        private static string baseUrl = "https://aviationweather.gov/";
        private readonly HttpClient _httpClient;

        public WeatherService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(baseUrl);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Metar?> GetMetarAsync(string? icao)
        {
            if (icao is null)
                return null;

            IEnumerable<Metar>? metars = await GetMetarAsync(new string[] { icao });

            if (metars is null)
                return null;

            return metars.FirstOrDefault();
        }

        public async Task<Metar?> GetMetarAsync(Airfield airfield)
            => await GetMetarAsync(airfield.ICAOCode);

        public async Task<IEnumerable<Metar>?> GetMetarAsync(IEnumerable<Airfield> airfields)
        {
            List<string> icaos = new List<string>();

            foreach(Airfield field in airfields)
            {
                if (field.ICAOCode is not null)
                    icaos.Add(field.ICAOCode);
            }

            return await GetMetarAsync(icaos);
        }

        public async Task<IEnumerable<Metar>?> GetMetarAsync(IEnumerable<string> icaos)
        {
            string joinedIcaos = string.Join(',', icaos);          
            string request = $"/cgi-bin/data/metar.php?ids={joinedIcaos}&format=json";

            IEnumerable<Metar>? metars = null;
            HttpResponseMessage response = await _httpClient.GetAsync(request);

            if (response.IsSuccessStatusCode)
            {
                metars = await response.Content.ReadAsAsync<IEnumerable<Metar>?>();
            }

            return metars;
        }
    }
}
