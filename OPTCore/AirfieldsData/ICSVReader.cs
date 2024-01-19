namespace OPTCore.AirfieldsData
{
    public interface ICSVReader
    {
        Task<string[]> ReadLinesAsync(string path);
    }
}
