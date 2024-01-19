using OPTCore.PerformanceCalculation.Models;

namespace OPTCore.PerformanceCalculation
{
    public interface IPerformanceCalculator
    {
        float CalculateV1(TOParameters parameters);
        float CalculateVr(TOParameters parameters);
        float CalculateV2(TOParameters parameters);
    }
}
