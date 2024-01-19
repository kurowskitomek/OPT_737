namespace OPTCore.PerformanceCalculation.Models
{
    public class TOPerformance : ITOPerformance
    {
        public Dictionary<Flaps, Dictionary<int, int?[]>> VSpeeds { get; }

        public Dictionary<int, Dictionary<int, int?>>[] PressAltAndTempCorr { get; }

        public Dictionary<int, Dictionary<int, int>> SlopeCorrection { get; }

        public Dictionary<int, Dictionary<int, int>> WindCorrection { get; }

        public Dictionary<int, Dictionary<int, int?>> Vmcg { get; }

        public Dictionary<int, Dictionary<int, int>> ClearwayCorrection { get; }

        public Dictionary<ReverseThrust, Dictionary<int, Dictionary<int, Dictionary<int, int>>>> SlushCorrection { get; }

        public Dictionary<ReverseThrust, Dictionary<RunwayCondition, Dictionary<int, Dictionary<int, int>>>> BrakingActionCorrection { get; }

        public Dictionary<int, int> AntiSkidInopCorrection { get; }

        public TOPerformance(
            Dictionary<Flaps, Dictionary<int, int?[]>> vSpeeds,
            Dictionary<int, Dictionary<int, int?>>[] pressAltAndTempCorrection,
            Dictionary<int, Dictionary<int, int>> slopeCorrection,
            Dictionary<int, Dictionary<int, int>> windCorrection,
            Dictionary<int, Dictionary<int, int?>> vmcg,
            Dictionary<int, Dictionary<int, int>> clearwayCorrection,
            Dictionary<ReverseThrust, Dictionary<int, Dictionary<int, Dictionary<int, int>>>> slushCorrection,
            Dictionary<ReverseThrust, Dictionary<RunwayCondition, Dictionary<int, Dictionary<int, int>>>> brakingActionCorrection,
            Dictionary<int, int> antiSkidInopCorrection)
        {
            VSpeeds = vSpeeds;
            PressAltAndTempCorr = pressAltAndTempCorrection;
            SlopeCorrection = slopeCorrection;
            WindCorrection = windCorrection;
            Vmcg = vmcg;
            ClearwayCorrection = clearwayCorrection;
            SlushCorrection = slushCorrection;
            BrakingActionCorrection = brakingActionCorrection;
            AntiSkidInopCorrection = antiSkidInopCorrection;
        }
    }
}
