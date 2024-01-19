using OPTCore.AirfieldsData;
using OPTCore.AirfieldsData.Models;
using OPTCore.PerformanceCalculation;
using OPTCore.PerformanceCalculation.Data;
using OPTCore.PerformanceCalculation.Models;
using OPTCore.WeatherData;
using OPTCore.WeatherData.Models;

namespace OPT_737_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITOPerformance dryMaxPerformance =
                new TOPerformance(
                    TOSpeedsDryMax.VSpeeds,
                    TOSpeedsDryMax.PressAltAndTempCorrection,
                    TOSpeedsDryMax.SlopeCorrection,
                    TOSpeedsDryMax.WindCorrection,
                    TOSpeedsDryMax.Vmcg,
                    TOSpeedsDryMax.ClearwayCorrection,
                    TOSpeedsDryMax.SlushV1Correction,
                    TOSpeedsDryMax.SlipperyV1Correction,
                    TOSpeedsDryMax.AntiSkidInopCorrection);

            ITOPerformance dry22KPerformance =
                new TOPerformance(
                    TOSpeedsDryMax.VSpeeds,
                    TOSpeedsDryMax.PressAltAndTempCorrection,
                    TOSpeedsDryMax.SlopeCorrection,
                    TOSpeedsDryMax.WindCorrection,
                    TOSpeedsDryMax.Vmcg,
                    TOSpeedsDryMax.ClearwayCorrection,
                    TOSpeedsDryMax.SlushV1Correction,
                    TOSpeedsDryMax.SlipperyV1Correction,
                    TOSpeedsDryMax.AntiSkidInopCorrection);

            ITOPerformance dry24KPerformance =
                new TOPerformance(
                    TOSpeedsDryMax.VSpeeds,
                    TOSpeedsDryMax.PressAltAndTempCorrection,
                    TOSpeedsDryMax.SlopeCorrection,
                    TOSpeedsDryMax.WindCorrection,
                    TOSpeedsDryMax.Vmcg,
                    TOSpeedsDryMax.ClearwayCorrection,
                    TOSpeedsDryMax.SlushV1Correction,
                    TOSpeedsDryMax.SlipperyV1Correction,
                    TOSpeedsDryMax.AntiSkidInopCorrection);

            ITOPerformance wetMaxPerformance =
                new TOPerformance(
                    TOSpeedsDryMax.VSpeeds,
                    TOSpeedsDryMax.PressAltAndTempCorrection,
                    TOSpeedsDryMax.SlopeCorrection,
                    TOSpeedsDryMax.WindCorrection,
                    TOSpeedsDryMax.Vmcg, 
                    TOSpeedsDryMax.ClearwayCorrection,
                    TOSpeedsDryMax.SlushV1Correction,
                    TOSpeedsDryMax.SlipperyV1Correction,
                    TOSpeedsDryMax.AntiSkidInopCorrection);

            ITOPerformance wet22KPerformance =
                new TOPerformance(
                    TOSpeedsDryMax.VSpeeds,
                    TOSpeedsDryMax.PressAltAndTempCorrection,
                    TOSpeedsDryMax.SlopeCorrection,
                    TOSpeedsDryMax.WindCorrection,
                    TOSpeedsDryMax.Vmcg,
                    TOSpeedsDryMax.ClearwayCorrection,
                    TOSpeedsDryMax.SlushV1Correction,
                    TOSpeedsDryMax.SlipperyV1Correction,
                    TOSpeedsDryMax.AntiSkidInopCorrection);

            ITOPerformance wet24KPerformance =
                new TOPerformance(
                    TOSpeedsDryMax.VSpeeds,
                    TOSpeedsDryMax.PressAltAndTempCorrection,
                    TOSpeedsDryMax.SlopeCorrection,
                    TOSpeedsDryMax.WindCorrection,
                    TOSpeedsDryMax.Vmcg, 
                    TOSpeedsDryMax.ClearwayCorrection,
                    TOSpeedsDryMax.SlushV1Correction,
                    TOSpeedsDryMax.SlipperyV1Correction,
                    TOSpeedsDryMax.AntiSkidInopCorrection);

            Dictionary<TOThrust, ITOPerformance> dryPerformance =
                new Dictionary<TOThrust, ITOPerformance>
                {
                    { TOThrust.Max, dryMaxPerformance },
                    { TOThrust.Derate22K, dry22KPerformance },
                    { TOThrust.Derate24K, dry24KPerformance }
                };

            Dictionary<TOThrust, ITOPerformance> wetPerformance =
                new Dictionary<TOThrust, ITOPerformance>
                {
                    { TOThrust.Max, wetMaxPerformance },
                    { TOThrust.Derate22K, wet22KPerformance },
                    { TOThrust.Derate24K, wet24KPerformance }
                };

            Dictionary<RunwayCondition, Dictionary<TOThrust, ITOPerformance>> dataSets
                = new Dictionary<RunwayCondition, Dictionary<TOThrust, ITOPerformance>>
                {
                    { RunwayCondition.Dry, dryPerformance },
                    { RunwayCondition.Good, wetPerformance }
                };

            PerformanceCalculator calc = 
                new PerformanceCalculator(dataSets);

            TOParameters parameters = new TOParameters
            {
                Thrust = TOThrust.Max,
                RunwayCondition = RunwayCondition.Dry,
                Flaps = Flaps.Flaps5,
                Weight = 51.456f,
                Temperature = 20,
                PressureAltitude = 1f,
                RunwaySlope = -0.2f,
                HeadWind = 0,
                ClearwayMStopway = 0,
                Slush = 0,
                ReverseThrust = ReverseThrust.Max,                
                AntiSkid = AntiSkid.Operative,                
                RunwayLength = 2400
            };

            float v1 = calc.CalculateV1(parameters);

            CSVReader csvReader = new CSVReader();
            AirfieldsDataBuilder runwayDataReader = new AirfieldsDataBuilder(csvReader);

            List<Airfield> airfields = runwayDataReader.BuildDataAsync()
                .GetAwaiter()
                .GetResult()
                .ToList();

            Console.WriteLine(airfields[0].ICAOCode);

            Airfield epkk = airfields.FirstOrDefault(a => a.ICAOCode == "EPKK");

            WeatherService weatherService = new WeatherService();

            Metar? metar = weatherService.GetMetarAsync("EPKK").GetAwaiter().GetResult();

            DataCalculator dataCalculator = new DataCalculator();

            float pressAlt = dataCalculator.CalculatePressAlt((float)metar.Altim, epkk.Runways[0].Elevation);

            Console.WriteLine(v1);
            Console.WriteLine(pressAlt);
        }
    }
}