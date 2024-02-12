using OPTCore.PerformanceCalculation.Models;

namespace OPTCore.PerformanceCalculation
{
    public class PerformanceCalculator : IPerformanceCalculator
    {
        private readonly Dictionary<TOThrust, ITOPerformance> _dataSets;

        public PerformanceCalculator(
            Dictionary<TOThrust, ITOPerformance> dataSets)
        {
            _dataSets = dataSets;
        }

        public float CalculateV1(TOParameters parameters)
        {
            if (parameters.RunwaySlope > 2 || parameters.RunwaySlope < -2)
                throw new OutsideSlopeEnvelopeException();

            if (parameters.HeadWind < -15 || parameters.HeadWind > 40)
                throw new OutsideWindEnvelopeException();

            if (parameters.RunwayCondition is RunwayCondition.Slush &&
                (parameters.Slush < 3 || parameters.Slush > 13))
                throw new OutsideAllowedSlushDepthException();

            if (parameters.RunwayCondition > RunwayCondition.Dry &&
                parameters.ClearwayMStopway > 0)
                throw new OutsideAllowedClearwayMinusStopwayRangeException();

            if (parameters.AntiSkid is AntiSkid.Inop &&
                parameters.RunwayCondition > RunwayCondition.Dry)
                throw new InopAntiSkidNotAllowedException();

            //RunwayCondition rwyCondition = RunwayCondition.Dry;//parameters.RunwayCondition;

            /*if (parameters.RunwayCondition > RunwayCondition.Good ||
                parameters.RunwayCondition > RunwayCondition.Dry && parameters.ReverseThrust is ReverseThrust.None)
                rwyCondition = RunwayCondition.Dry;*/

            ITOPerformance dataSet = _dataSets[parameters.Thrust];

            float v1 = CalculateBaseVSpeed(VSpeed.V1, parameters, dataSet);

            float densAltCorr =
                CalculateDensAltCorrection(
                    dataSet,
                    parameters.Temperature,
                    parameters.PressureAltitude,
                    VSpeed.V1);

            float slopeCorr =
                CalculateSlopeCorrection(
                    dataSet,
                    parameters.RunwaySlope,
                    parameters.Weight);

            float windCorr =
                CalculateWindCorrection(
                    dataSet,
                    parameters.HeadWind,
                    parameters.Weight);

            v1 += densAltCorr;
            v1 += slopeCorr;
            v1 += windCorr;

            if (parameters.RunwayCondition is RunwayCondition.Slush)
            {
                float slushCorr =
                    CalculateSlushCorrection(
                        dataSet,
                        parameters.Slush,
                        parameters.Weight,
                        parameters.PressureAltitude,
                        parameters.ReverseThrust);

                v1 += slushCorr;
            }
            else if (parameters.RunwayCondition > RunwayCondition.Dry)// ||
                    //parameters.RunwayCondition > RunwayCondition.Dry && parameters.ReverseThrust is ReverseThrust.None)
            {
                float brkActionCorr =
                    CalculateBrakingActionCorrection(
                        dataSet,
                        parameters.RunwayCondition,
                        parameters.ReverseThrust,
                        parameters.Weight,
                        parameters.PressureAltitude);

                v1 += brkActionCorr;
            }

            if (parameters.AntiSkid is AntiSkid.Inop)
            {
                float antiSkidInopCorr =
                    CalculateAntiSkidInopCorrection(dataSet, parameters.RunwayLength);

                v1 += antiSkidInopCorr;
            }

            if (parameters.RunwayCondition > RunwayCondition.Dry &&
                parameters.ReverseThrust is ReverseThrust.OneInop)
            {
                int reverserInopCorr = CalculateThrustReverserInopCorrection();

                v1 += reverserInopCorr;
            }

            float clearwayCorr =
                CalculateClearwayCorrection(dataSet, parameters.ClearwayMStopway, (float)v1);

            v1 += clearwayCorr;

            float vmcg =
                CalculateVmcg(dataSet, parameters.PressureAltitude, parameters.Temperature);

            if (v1 < vmcg)
                v1 = vmcg;

            float vr = CalculateVr(parameters);

            if (vr < v1)
                v1 = vr;

            return (float)v1;
        }

        public float CalculateVr(TOParameters parameters)
        {
            RunwayCondition rwyCondition = parameters.RunwayCondition;

            if (parameters.RunwayCondition > RunwayCondition.Good)
                rwyCondition = RunwayCondition.Dry;

            ITOPerformance dataSet = _dataSets[parameters.Thrust];
            float vr = CalculateBaseVSpeed(VSpeed.Vr, parameters, dataSet);
            float vmcg = CalculateVmcg(dataSet, parameters.PressureAltitude, parameters.Temperature);

            float densAltCorr =
                CalculateDensAltCorrection(
                    dataSet,
                    parameters.Temperature,
                    parameters.PressureAltitude,
                    VSpeed.Vr);

            vr += densAltCorr;

            if (vr < vmcg)
                vr = vmcg;

            return (float)vr;
        }

        public float CalculateV2(TOParameters parameters)
        {
            RunwayCondition rwyCondition = parameters.RunwayCondition;

            if (parameters.RunwayCondition > RunwayCondition.Good)
                rwyCondition = RunwayCondition.Dry;

            ITOPerformance dataSet = _dataSets[parameters.Thrust];
            float vr = CalculateBaseVSpeed(VSpeed.Vr, parameters, dataSet);
            float densAltCorr =
                CalculateDensAltCorrection(
                    dataSet,
                    parameters.Temperature,
                    parameters.PressureAltitude,
                    VSpeed.Vr);

            float adjustedVr = vr + densAltCorr;
            float vmcg = CalculateVmcg(dataSet, parameters.PressureAltitude, parameters.Temperature);

            float v2 = CalculateBaseVSpeed(VSpeed.V2, parameters, dataSet);

            if (adjustedVr < vmcg)
            {
                float diff = vmcg - vr;
                v2 += diff;
            }
            else
            {
                densAltCorr =
                    CalculateDensAltCorrection(
                        dataSet,
                        parameters.Temperature,
                        parameters.PressureAltitude,
                        VSpeed.V2);

                vr += densAltCorr;
            }

            return (float)v2;
        }

        #region private helpers

        private int CalculateThrustReverserInopCorrection()
            => -2;

        private float CalculateAntiSkidInopCorrection(
            ITOPerformance dataSet,
            int rwyLength)
        {
            if (rwyLength > 4000)
                rwyLength = 4000;

            if (rwyLength < 2000)
                rwyLength = 2000;

            (int lower, int upper) lengthKeys = BinarySearch(dataSet.AntiSkidCorr, rwyLength);
            float antiSkidInopCorr = dataSet.AntiSkidCorr[lengthKeys.lower];

            antiSkidInopCorr += 
                Interpolate(rwyLength, lengthKeys, (int)antiSkidInopCorr, dataSet.AntiSkidCorr[lengthKeys.upper]);

            return antiSkidInopCorr;
        }

        private float CalculateDensAltCorrection(
            ITOPerformance dataSet,
            int temp,
            float pressAlt,
            VSpeed vSpeed)
        {
            if (temp > 70 || temp < -60)
                throw new OutsideTempEnvelopeException();

            if (pressAlt < -2 || pressAlt > 10)
                throw new OutsidePressAltEnvelopeException();

            (int lower, int upper) tempKeys = BinarySearch(dataSet.DensAltCorr[(int)vSpeed], temp);
            (int lower, int upper) pressAltKeys = BinarySearch(dataSet.DensAltCorr[(int)vSpeed][tempKeys.lower], pressAlt);

            int? basePressAltAndTempCorr = dataSet.DensAltCorr[(int)vSpeed][tempKeys.lower][pressAltKeys.lower];
            int? tempUpperValue = dataSet.DensAltCorr[(int)vSpeed][tempKeys.upper][pressAltKeys.lower];
            int? pressAltUpperValue = dataSet.DensAltCorr[(int)vSpeed][tempKeys.lower][pressAltKeys.upper];

            if (basePressAltAndTempCorr is null || 
                tempUpperValue is null ||
                pressAltUpperValue is null)
                throw new OutsideDensAltEnvelopeException();

            float pressAltAndTempCorr = (float)basePressAltAndTempCorr;

            pressAltAndTempCorr += Interpolate(temp, tempKeys, (int)basePressAltAndTempCorr, (int)tempUpperValue);
            pressAltAndTempCorr += Interpolate(pressAlt, pressAltKeys, (int)basePressAltAndTempCorr, (int)pressAltUpperValue);

            return pressAltAndTempCorr;
        }

        private float CalculateSlopeCorrection(
            ITOPerformance dataSet,
            float slope,
            float weight)
        {
            if (slope > 2 || slope < -2)
                throw new OutsideSlopeEnvelopeException();

            if (weight < 40 || weight > 90)
                throw new OutsideWeightEnvelopeException();

            (int lower, int upper) weightKeys = BinarySearch(dataSet.SlopeCorr, weight);
            (int lower, int upper) slopeKeys = BinarySearch(dataSet.SlopeCorr[weightKeys.lower], slope);

            int weightUpperValue = dataSet.SlopeCorr[weightKeys.upper][slopeKeys.lower];
            int slopeUpperValue = dataSet.SlopeCorr[weightKeys.lower][slopeKeys.upper];
            int baseSlopeCorr = dataSet.SlopeCorr[weightKeys.lower][slopeKeys.lower];
            float slopeCorr = baseSlopeCorr;

            slopeCorr += Interpolate(weight, weightKeys, baseSlopeCorr, weightUpperValue);
            slopeCorr += Interpolate(slope, slopeKeys, baseSlopeCorr, slopeUpperValue);

            return slopeCorr;
        }

        private float CalculateWindCorrection(
            ITOPerformance dataSet,
            int headWind,
            float weight)
        {
            if (headWind < -15 || headWind > 40)
                throw new OutsideWindEnvelopeException();

            if (weight < 40 || weight > 90)
                throw new OutsideWeightEnvelopeException();

            (int lower, int upper) weightKeys = BinarySearch(dataSet.WindCorr, weight);
            (int lower, int upper) windKeys = BinarySearch(dataSet.WindCorr[weightKeys.lower], headWind);

            int weightUpperValue = dataSet.WindCorr[weightKeys.upper][windKeys.lower];
            int windUpperValue = dataSet.WindCorr[weightKeys.lower][windKeys.upper];
            int baseWindCorr = dataSet.WindCorr[weightKeys.lower][windKeys.lower];
            float windCorr = baseWindCorr;

            windCorr += Interpolate(weight, weightKeys, baseWindCorr, weightUpperValue);
            windCorr += Interpolate(headWind, windKeys, baseWindCorr, windUpperValue);

            return windCorr;
        }
        
        private float CalculateVmcg(
            ITOPerformance dataSet,
            float pressAlt,
            int temp)
        {
            if (pressAlt < -2 || pressAlt > 10)
                throw new OutsidePressAltEnvelopeException();

            if (temp > 70 || temp < -60)
                throw new OutsideTempEnvelopeException();

            (int lower, int upper) tempKeys = BinarySearch(dataSet.Vmcg, temp);
            (int lower, int upper) pressAltKeys = BinarySearch(dataSet.Vmcg[tempKeys.lower], pressAlt);

            int? baseVmcg = dataSet.Vmcg[tempKeys.lower][pressAltKeys.lower];
            int? tempUpperValue = dataSet.Vmcg[tempKeys.upper][pressAltKeys.lower];
            int? pressAltUpperValue = dataSet.Vmcg[tempKeys.lower][pressAltKeys.upper];

            if (baseVmcg is null ||
                tempUpperValue is null ||
                pressAltUpperValue is null)
                throw new OutsideDensAltEnvelopeException();

            float vmcg = (float)baseVmcg;

            vmcg += Interpolate(temp, tempKeys, (int)baseVmcg, (int)tempUpperValue);
            vmcg += Interpolate(pressAlt, pressAltKeys, (int)baseVmcg, (int)pressAltUpperValue);

            return vmcg;
        }

        private float CalculateSlushCorrection(
            ITOPerformance dataSet,
            int slush,
            float weight,
            float pressAlt,
            ReverseThrust revThrust)
        {
            if (revThrust == ReverseThrust.OneInop)
                revThrust = ReverseThrust.None;

            if (weight < 40 || weight > 90)
                throw new OutsideWeightEnvelopeException();

            if (slush < 3 || slush > 13)
                throw new OutsideAllowedSlushDepthException();

            if (pressAlt < -2 || pressAlt > 10)
                throw new OutsidePressAltEnvelopeException();

            (int lower, int upper) slushKeys = BinarySearch(dataSet.SlushCorr[revThrust], slush);
            (int lower, int upper) weightKeys = BinarySearch(dataSet.SlushCorr[revThrust][slushKeys.lower], weight);
            (int lower, int upper) pressAltKeys = BinarySearch(dataSet.SlushCorr[revThrust][slushKeys.lower][weightKeys.lower], pressAlt);

            int slushUpperValue = dataSet.SlushCorr[revThrust][slushKeys.upper][weightKeys.lower][pressAltKeys.lower];
            int weightUpperValue = dataSet.SlushCorr[revThrust][slushKeys.lower][weightKeys.lower][pressAltKeys.upper];
            int pressAltUpperValue = dataSet.SlushCorr[revThrust][slushKeys.lower][weightKeys.upper][pressAltKeys.lower];
            int baseSlushCorr = dataSet.SlushCorr[revThrust][slushKeys.lower][weightKeys.lower][pressAltKeys.lower];
            float slushCorr = baseSlushCorr;

            slushCorr += Interpolate(slush, slushKeys, baseSlushCorr, slushUpperValue);
            slushCorr += Interpolate(weight, weightKeys, baseSlushCorr, weightUpperValue);
            slushCorr += Interpolate(pressAlt, pressAltKeys, baseSlushCorr, pressAltUpperValue);

            return slushCorr;
        }

        private float CalculateBrakingActionCorrection(
            ITOPerformance dataSet,
            RunwayCondition brakingAction,
            ReverseThrust revThrust,
            float weight,
            float pressAlt)
        {
            if (revThrust == ReverseThrust.OneInop)
                revThrust = ReverseThrust.None;

            if (weight < 40 || weight > 90)
                throw new OutsideWeightEnvelopeException();

            if (pressAlt < -2 || pressAlt > 10)
                throw new OutsidePressAltEnvelopeException();

            if (brakingAction < RunwayCondition.Good ||
                brakingAction > RunwayCondition.Poor)
                throw new NotAllowedRunwayConditionException();

            if (pressAlt < 0)
                pressAlt = 0;

            (int lower, int upper) weightKeys = BinarySearch(dataSet.BrakingActionCorr[revThrust][brakingAction], weight);
            (int lower, int upper) pressAltKeys = BinarySearch(dataSet.BrakingActionCorr[revThrust][brakingAction][weightKeys.lower], pressAlt);

            int weightUpperValue = dataSet.BrakingActionCorr[revThrust][brakingAction][weightKeys.upper][pressAltKeys.lower];
            int pressAltUpperValue = dataSet.BrakingActionCorr[revThrust][brakingAction][weightKeys.lower][pressAltKeys.upper];
            int baseBrakingActionCorr = dataSet.BrakingActionCorr[revThrust][brakingAction][weightKeys.lower][pressAltKeys.lower];
            float brakingActionCorr = baseBrakingActionCorr;

            brakingActionCorr += Interpolate(weight, weightKeys, baseBrakingActionCorr, weightUpperValue);
            brakingActionCorr += Interpolate(pressAlt, pressAltKeys, baseBrakingActionCorr, pressAltUpperValue);

            return brakingActionCorr;
        }

        private float CalculateClearwayCorrection(
            ITOPerformance dataSet,
            int clearwayMStopway,
            float v1)
        {
            if (clearwayMStopway > 200 || clearwayMStopway < -300)
                throw new OutsideAllowedClearwayMinusStopwayRangeException();

            (int lower, int upper) clearwayMstopwayKeys = BinarySearch(dataSet.ClearwayCorr, clearwayMStopway);
            (int lower, int upper) v1Keys = BinarySearch(dataSet.ClearwayCorr[clearwayMstopwayKeys.lower], v1);

            int clrwayMstpwayUpperValue = dataSet.ClearwayCorr[clearwayMstopwayKeys.upper][v1Keys.lower];
            int v1UpperValue = dataSet.ClearwayCorr[clearwayMstopwayKeys.lower][v1Keys.upper];
            int baseClearwayCorr = dataSet.ClearwayCorr[clearwayMstopwayKeys.lower][v1Keys.lower];
            float clearwayCorr = baseClearwayCorr;

            clearwayCorr += Interpolate(clearwayMStopway, clearwayMstopwayKeys, baseClearwayCorr, clrwayMstpwayUpperValue);
            clearwayCorr += Interpolate(v1, v1Keys, baseClearwayCorr, v1UpperValue);

            return clearwayCorr;
        }

        private float CalculateBaseVSpeed(VSpeed vSpeed, TOParameters parameters, ITOPerformance dataSet)
        {
            if (parameters.Weight < 40 || parameters.Weight > 90)
                throw new OutsideWeightEnvelopeException();

            if (parameters.Temperature > 70 || parameters.Temperature < -60)
                throw new OutsideTempEnvelopeException();

            if (parameters.PressureAltitude < -2 || parameters.PressureAltitude > 10)
                throw new OutsidePressAltEnvelopeException();

            (int lower, int upper) weightKeys = BinarySearch(dataSet.VSpeeds[parameters.Flaps], (int)parameters.Weight);

            int? upperValue = dataSet.VSpeeds[parameters.Flaps][weightKeys.upper][(int)vSpeed];
            float? v = dataSet.VSpeeds[parameters.Flaps][weightKeys.lower][(int)vSpeed];     

            if (v is null ||
                upperValue is null)
                throw new OutsideWeightEnvelopeException();

            v += Interpolate(parameters.Weight, weightKeys, (int)v, (int)upperValue);

            return (float)v;
        }

        private float Interpolate(          
            float x,
            (int lower, int upper) keys,
            int lowerValue, 
            int upperValue)
        {
            if (keys.lower == keys.upper)
                return 0;

            float dX = Math.Abs(x - keys.lower);
            float dY = Math.Abs(upperValue - lowerValue);

            return dX / Math.Abs(keys.upper - keys.lower) * dY;
        }

        private (int, int) BinarySearch<TValue>(SortedList<int, TValue> list, float key)
        {
            if (list is null)
                return default;
          
            int start = 0;
            int end = list.Count() - 1;

            while (start < end - 1)
            {
                int pivot = (start + end) / 2;
                int element = list.GetKeyAtIndex(pivot);             

                if (element > key)
                    end = pivot;
                else
                    start = pivot;
            }

            int high = list.GetKeyAtIndex(end);
            int low = list.GetKeyAtIndex(start);

            if (key.Equals(high))           
                low = high;           
            else if (key.Equals(low))
                high = low;

            return (low, high);
        }

        #endregion
    }
}