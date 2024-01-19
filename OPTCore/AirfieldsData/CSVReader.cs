namespace OPTCore.AirfieldsData
{
    public class CSVReader : ICSVReader
    {
        public async Task<string[]> ReadLinesAsync(string path)
        {
            if (!File.Exists(path))
                return new string[0];

            string[] lines = await File.ReadAllLinesAsync(path);

            return lines;
        }
    }
}
