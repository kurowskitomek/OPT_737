namespace OPTCore.WeatherData
{
    public interface IDataCalculator
    {
        float CalculatePressAlt(float qnh, float elev);
        double WindComponent(int windDir, int hdg, int windSpd);
    }
}
