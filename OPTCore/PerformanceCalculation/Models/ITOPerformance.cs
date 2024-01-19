namespace OPTCore.PerformanceCalculation.Models
{
    public interface ITOPerformance
    {
        Dictionary<Flaps, Dictionary<int, int?[]>> VSpeeds { get; }
        Dictionary<int, Dictionary<int, int?>>[] PressAltAndTempCorr { get; }
        Dictionary<int, Dictionary<int, int>> SlopeCorrection { get; }
        Dictionary<int, Dictionary<int, int>> WindCorrection { get; }
        Dictionary<int, Dictionary<int, int?>> Vmcg { get; }
        Dictionary<int, Dictionary<int, int>> ClearwayCorrection { get; }
        Dictionary<ReverseThrust, Dictionary<int, Dictionary<int, Dictionary<int, int>>>> SlushCorrection { get; }
        Dictionary<ReverseThrust, Dictionary<RunwayCondition, Dictionary<int, Dictionary<int, int>>>> BrakingActionCorrection { get; }
        Dictionary<int, int> AntiSkidInopCorrection { get; }
    }
}
