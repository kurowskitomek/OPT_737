using System.Globalization;
using OPTCore.AirfieldsData.Models;

namespace OPTCore.AirfieldsData
{
    public class AirfieldsDataBuilder : IAirfieldsDataBuilder
    {
        private const double meterInFeet = 3.28084;
        private const string runwaysData = "AirfieldsData/Data/runways.csv";
        private readonly ICSVReader _csvReader;

        public IEnumerable<Airfield> Airfields { get; private set; }

        public bool HasData => Airfields!.Count() > 0;

        public AirfieldsDataBuilder(ICSVReader csvReader)
        {
            Airfields = new List<Airfield>();
            _csvReader = csvReader;
        }

        public async Task<IEnumerable<Airfield>> BuildDataAsync()
        {
            if (HasData)
                return Airfields;

            string[] rawRunways = (await _csvReader.ReadLinesAsync(runwaysData))
                .Skip(1)
                .ToArray();

            Airfield? currentAirfield = null;
            List<Airfield> airfields = new List<Airfield>();
            string lastICAO = "";

            foreach (string line in rawRunways)
            {
                string[] data = line.Split(',');

                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i].StartsWith('\"') && !data[i].EndsWith('\"'))
                    {
                        data[i] = data[i] + ", " + data[i + 1];

                        List<string> dataList = data.ToList();
                        dataList.RemoveAt(i + 1);

                        data = dataList.ToArray();
                    }

                    data[i] = data[i].Replace("\"", "");
                }

                string icao = data[2];

                if (lastICAO != icao)
                {
                    lastICAO = icao;

                    Airfield airfield = new Airfield
                    {
                        ICAOCode = icao,
                        Runways = new List<Runway>()
                    };

                    airfields.Add(airfield);
                    currentAirfield = airfield;
                }

                (Runway?, Runway?) runways = BuildRunways(data);

                Runway? runway1 = runways.Item1;
                Runway? runway2 = runways.Item2;

                if (runway1 != null && runway2 != null)
                {
                    float elevDiff = FeetToMeters(Math.Abs(runway1.Elevation - runway2.Elevation));
                    float lenght = runway1.Length - runway1.DisplacedThreshold - runway2.DisplacedThreshold;
                    float slope = elevDiff / lenght * 100;

                    if (runway1.Elevation > runway2.Elevation)
                    {
                        runway1.Slope = slope;
                        runway2.Slope = -slope;
                    }
                    else
                    {
                        runway1.Slope = -slope;
                        runway2.Slope = slope;
                    }
                }

                if (runway1 != null)
                    currentAirfield!.Runways!.Add(runway1);

                if (runway2 != null)
                    currentAirfield!.Runways!.Add(runway2);
            }

            Airfields = airfields;

            return airfields;
        }

        private Runway? BuildRunway(string[] data, int startIndex)
        {
            if (string.IsNullOrEmpty(data[startIndex]))
                return null;

            string runwayId = data[startIndex];
            string surface = data[5];
            int length = 0;
            int width = 0;
            int elevation = 0;
            int trueHdg = 0;
            int displacedThr = 0;
            bool closed = false;
            bool lighted = false;
            double latitude = 0;
            double longitude = 0;

            if (!string.IsNullOrEmpty(data[3]))
                length = FeetToMeters(data[3]);

            if (!string.IsNullOrEmpty(data[4]))
                width = FeetToMeters(data[4]);

            if (!string.IsNullOrEmpty(data[6]))
                lighted = int.Parse(data[6]) != 0;

            if (!string.IsNullOrEmpty(data[7]))
                closed = int.Parse(data[7]) != 0;

            if (!string.IsNullOrEmpty(data[startIndex + 1]))
                latitude = double.Parse(data[startIndex + 1], CultureInfo.InvariantCulture);

            if (!string.IsNullOrEmpty(data[startIndex + 2]))
                longitude = double.Parse(data[startIndex + 2], CultureInfo.InvariantCulture);

            if (!string.IsNullOrEmpty(data[startIndex + 3]))
                elevation = (int)Math.Round(float.Parse(data[startIndex + 3], CultureInfo.InvariantCulture));

            if (!string.IsNullOrEmpty(data[startIndex + 4]))
                trueHdg = (int)Math.Round(float.Parse(data[startIndex + 4], CultureInfo.InvariantCulture));

            if (!string.IsNullOrEmpty(data[startIndex + 5]))
                displacedThr = FeetToMeters(data[startIndex + 5]);

            Runway runway = new Runway
            {
                Designator = runwayId,
                Surface = surface,
                Length = length,
                Width = width,
                DisplacedThreshold = displacedThr,
                Elevation = elevation,
                TrueHeading = trueHdg,
                Closed = closed,
                Lighted = lighted,
                Latitude = latitude,
                Longitude = longitude
            };

            return runway;
        }

        private void CalculateDeclaredDistances(Runway runway1, Runway runway2) 
        {
            runway1.TORA = runway1.Length - runway2.DisplacedThreshold;
            runway1.ASDA = runway1.Length;
            runway1.LDA = runway1.Length - runway1.DisplacedThreshold;
            runway1.TODA = runway1.Length;
        }

        private (Runway?, Runway?) BuildRunways(string[] data)
        {
            Runway? runway1 = BuildRunway(data, 8);
            Runway? runway2 = BuildRunway(data, 14);

            if (runway1 is not null && runway2 is not null)
            {
                CalculateDeclaredDistances(runway1, runway2);
                CalculateDeclaredDistances(runway2, runway1);
            }

            return (runway1, runway2);
        }

        private int FeetToMeters(string length)
            => (int)Math.Round(float.Parse(length, CultureInfo.InvariantCulture) / meterInFeet);

        private float FeetToMeters(float lenght)
            => lenght / (float)meterInFeet;
    }
}
