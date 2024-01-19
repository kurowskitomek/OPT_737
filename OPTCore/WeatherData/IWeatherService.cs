using OPTCore.AirfieldsData.Models;
using OPTCore.WeatherData.Models;

namespace OPTCore.WeatherData
{
    public interface IWeatherService
    {
        Task<Metar?> GetMetarAsync(string icao);
        Task<Metar?> GetMetarAsync(Airfield airfield);
        Task<IEnumerable<Metar>?> GetMetarAsync(IEnumerable<Airfield> airfields);
        Task<IEnumerable<Metar>?> GetMetarAsync(IEnumerable<string> icaos);
    }
}
