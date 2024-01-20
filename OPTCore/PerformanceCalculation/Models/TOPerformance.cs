namespace OPTCore.PerformanceCalculation.Models
{
    public class TOPerformance : ITOPerformance
    {
        public Dictionary<Flaps, SortedList<int, int?[]>> VSpeeds { get; }

        public SortedList<int, SortedList<int, int?>>[] DensAltCorr { get; }

        public SortedList<int, SortedList<int, int>> SlopeCorr { get; }

        public SortedList<int, SortedList<int, int>> WindCorr { get; }

        public SortedList<int, SortedList<int, int?>> Vmcg { get; }

        public SortedList<int, SortedList<int, int>> ClearwayCorr { get; }

        public Dictionary<ReverseThrust, SortedList<int, SortedList<int, SortedList<int, int>>>> SlushCorr { get; }

        public Dictionary<ReverseThrust, Dictionary<RunwayCondition, SortedList<int, SortedList<int, int>>>> BrakingActionCorr { get; }

        public SortedList<int, int> AntiSkidCorr { get; }

        public TOPerformance(
            Dictionary<Flaps, SortedList<int, int?[]>> vSpeeds,
            SortedList<int, SortedList<int, int?>>[] densAltCorr,
            SortedList<int, SortedList<int, int>> slopeCorr,
            SortedList<int, SortedList<int, int>> windCorr,
            SortedList<int, SortedList<int, int?>> vmcg,
            SortedList<int, SortedList<int, int>> clearwayCorr,
            Dictionary<ReverseThrust, SortedList<int, SortedList<int, SortedList<int, int>>>> slushCorr,
            Dictionary<ReverseThrust, Dictionary<RunwayCondition, SortedList<int, SortedList<int, int>>>> brakingActionCorr,
            SortedList<int, int> antiSkidCorr)
        {
            VSpeeds = vSpeeds;
            DensAltCorr = densAltCorr;
            SlopeCorr = slopeCorr;
            WindCorr = windCorr;
            Vmcg = vmcg;
            ClearwayCorr = clearwayCorr;
            SlushCorr = slushCorr;
            BrakingActionCorr = brakingActionCorr;
            AntiSkidCorr = antiSkidCorr;
        }
    }
}
