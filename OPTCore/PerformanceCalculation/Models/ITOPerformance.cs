namespace OPTCore.PerformanceCalculation.Models
{
    public interface ITOPerformance
    {
        Dictionary<Flaps, SortedList<int, int?[]>> VSpeeds { get; }
        SortedList<int, SortedList<int, int?>>[] DensAltCorr { get; }
        SortedList<int, SortedList<int, int>> SlopeCorr { get; }
        SortedList<int, SortedList<int, int>> WindCorr { get; }
        SortedList<int, SortedList<int, int?>> Vmcg { get; }
        SortedList<int, SortedList<int, int>> ClearwayCorr { get; }
        Dictionary<ReverseThrust, SortedList<int, SortedList<int, SortedList<int, int>>>> SlushCorr { get; }
        Dictionary<ReverseThrust, Dictionary<RunwayCondition, SortedList<int, SortedList<int, int>>>> BrakingActionCorr { get; }
        SortedList<int, int> AntiSkidCorr { get; }
    }
}
