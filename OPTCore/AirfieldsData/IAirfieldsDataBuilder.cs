using OPTCore.AirfieldsData.Models;

namespace OPTCore.AirfieldsData
{
    public interface IAirfieldsDataBuilder
    {
        bool HasData { get; }
        IEnumerable<Airfield> Airfields { get; }
        Task<IEnumerable<Airfield>> BuildDataAsync();
    }
}
