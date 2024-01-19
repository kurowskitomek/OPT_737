namespace OPTCore.WeatherData
{
    public class DataCalculator : IDataCalculator
    {
        private const double feetToMeters = 0.3048;
        private const double metersToFeet = 3.28084;

        private const double R = 287.058;
        private const double L = 0.065;
        private const double T = 288.15;
        private const double P = 1013.25;
        private const double g = 9.81;

        public float CalculatePressAlt(float qnh, float elev)
        {
            elev = (float)FeetToMeters(elev);

            double pressAlt = elev + T / L * (1 - Math.Pow(qnh / P, R * L / g));

            pressAlt = MetersToFeet(pressAlt);

            return (float)pressAlt;
        }

        private double FeetToMeters(double feet)
            => feet * feetToMeters;

        private double MetersToFeet(double meters)
            => meters * metersToFeet;

        public double WindComponent(int windDir, int hdg, int windSpd)
        {
            int angle = Math.Abs(windDir - hdg);
            double component = windSpd * Math.Sin(angle);

            return component;
        }
    }
}
