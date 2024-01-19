using OPTCore.PerformanceCalculation.Models;

namespace OPTCore.PerformanceCalculation
{
    public class PerformanceCalculator : IPerformanceCalculator
    {
        private readonly Dictionary<RunwayCondition, Dictionary<TOThrust, ITOPerformance>> _dataSets;

        public PerformanceCalculator(
            Dictionary<RunwayCondition, Dictionary<TOThrust, ITOPerformance>> dataSets)
        {
            _dataSets = dataSets;
        }

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

            int lengthStep = 500;
            int keyLength = rwyLength / lengthStep * lengthStep;
            float antiSkidInopCorr = dataSet.AntiSkidInopCorrection[keyLength];

            if (rwyLength % lengthStep != 0)
            {
                int upperValue = dataSet.AntiSkidInopCorrection[keyLength + lengthStep];
                int dLength = rwyLength - keyLength;
                float dAntiSkidInopCorr = upperValue - antiSkidInopCorr;

                antiSkidInopCorr += dLength / lengthStep * dAntiSkidInopCorr;
            }

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

            int tempStep = 10;
            int pressAltStep = 2;
            int keyTemp = temp / tempStep * tempStep;
            int keyPressAlt = (int)pressAlt / pressAltStep * pressAltStep;

            if (tempStep < 20)
            {
                keyTemp = -60;
                tempStep = 80;
            }

            float? basePressAltAndTempCorr = dataSet.PressAltAndTempCorr[(int)vSpeed][keyTemp][keyPressAlt];

            if (basePressAltAndTempCorr is null)
                throw new OutsideDensAltEnvelopeException();

            float pressAltAndTempCorr = (float)basePressAltAndTempCorr;

            if (temp % tempStep != 0)
            {
                //if (temp < 0)
                   // tempStep = -60;

                int? upperValue = dataSet.PressAltAndTempCorr[0][keyTemp + tempStep][keyPressAlt];

                if (upperValue is null)
                    throw new OutsideDensAltEnvelopeException();

                int dTemp = temp - keyTemp;
                float dPressAltAndTempCorr = (float)upperValue - (float)basePressAltAndTempCorr;

                pressAltAndTempCorr += dTemp / Math.Abs(tempStep) * dPressAltAndTempCorr;
            }

            if (pressAlt % pressAltStep != 0)
            {
                if (pressAlt < 0)
                    pressAltStep = -1 * pressAltStep;

                int? upperValue = dataSet.PressAltAndTempCorr[0][keyTemp][keyPressAlt + pressAltStep];

                if (upperValue is null)
                    throw new OutsideDensAltEnvelopeException();

                float dPressAlt = pressAlt - keyPressAlt;
                float dPressAltAndTempCorr = (int)upperValue - (float)basePressAltAndTempCorr;

                pressAltAndTempCorr += dPressAlt / Math.Abs(pressAltStep) * dPressAltAndTempCorr;
            }

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

            int weightStep = 10;
            int slopeStep = 1;
            int keySlope = (int)slope;
            int keyWeight = (int)weight / weightStep * weightStep;
            float baseSlopeCorr = dataSet.SlopeCorrection[keyWeight][keySlope];
            float slopeCorr = baseSlopeCorr;

            if (weight % weightStep != 0)
            {
                float dWeight = weight - keyWeight;

                float upperValue =
                    dataSet.SlopeCorrection[keyWeight + weightStep][keySlope];
                float dSlopeCorr =
                    (int)upperValue - baseSlopeCorr;

                slopeCorr += dWeight / weightStep * dSlopeCorr;
            }

            if (slope != Math.Floor(slope))
            {
                if (slope < 0)
                    slopeStep = -1 * slopeStep;

                int upperValue = dataSet.SlopeCorrection[keyWeight][keySlope + slopeStep];
                float dSlope = slope - keySlope;
                float dSlopeCorr = upperValue - baseSlopeCorr;

                slopeCorr += dSlope * dSlopeCorr;
            }

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

            int windStep = 10;
            int weightStep = 10;
            int keyWind = headWind / windStep * windStep;
            int keyWeight = (int)weight / weightStep * weightStep;
            float baseWindCorr = dataSet.WindCorrection[keyWeight][keyWind];
            float windCorr = baseWindCorr;

            if (headWind % windStep != 0)
            {
                if (headWind < 0)
                    windStep = -5;

                int upperValue = dataSet.WindCorrection[keyWeight][keyWind + windStep];
                int dWind = headWind - keyWind;
                float dWindCorr = upperValue - baseWindCorr;

                windCorr += dWind / Math.Abs(windStep) * dWindCorr;
            }

            if (weight % weightStep != 0)
            {
                float dWeight = weight - keyWeight;
                float upperValue = dataSet.WindCorrection[keyWeight + weightStep][keyWind];
                float dWindCorr = (int)upperValue - baseWindCorr;

                windCorr += dWeight / weightStep * baseWindCorr;
            }

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

            int tempStep = 10;
            int pressAltStep = 2;
            int keyTemp = temp / tempStep * tempStep;
            int keyPressAlt = (int)pressAlt / pressAltStep * pressAltStep;

            if (tempStep < 20)
            {
                keyTemp = -60;
                tempStep = 80;
            }

            float? baseVmcg = dataSet.Vmcg[keyTemp][keyPressAlt];

            if (baseVmcg is null)
                throw new OutsideDensAltEnvelopeException();

            float vmcg = (float)baseVmcg;

            if (temp % tempStep != 0)
            {
                //if (temp < 0)
                  //  tempStep = -60;

                int dTemp = temp - keyTemp;
                float? upperValue = dataSet.Vmcg[keyTemp + tempStep][keyPressAlt];

                if (upperValue is null)
                    throw new OutsideDensAltEnvelopeException();

                float dVmcg = (int)upperValue - (float)baseVmcg;
                vmcg += dTemp / Math.Abs(tempStep) * dVmcg;
            }

            if (pressAlt % pressAltStep != 0)
            {
                if (pressAlt < 0)
                    pressAltStep = -1 * pressAltStep;

                float dPressAlt = pressAlt - keyPressAlt;
                float? upperValue = dataSet.Vmcg[keyTemp][keyPressAlt + pressAltStep];

                if (upperValue is null)
                    throw new OutsideDensAltEnvelopeException();

                float dVmcg = (int)upperValue - (float)baseVmcg;
                vmcg += dPressAlt / Math.Abs(pressAltStep) * dVmcg;
            }

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

            int pressAltStep = 5;
            int slushStep = 3;
            int weightStep = 5;
            int keyPressAlt = (int)pressAlt / pressAltStep * pressAltStep;

            if (pressAlt < 0)
                keyPressAlt = 0;

            int keyWeight = (int)weight / weightStep * weightStep;
            int keySlush = slush / slushStep * slushStep;

            if (slush >= 6 && slush < 13)
            {
                keySlush = 6;
                slushStep = 7;
            }
            else if (slush == 13)
                keySlush = 13;

            float baseSlushCorr = dataSet.SlushCorrection[revThrust][keySlush][keyWeight][keyPressAlt];

            float slushCorr = baseSlushCorr;

            if ((slush % slushStep != 0 || slush == 12) && slush != 13)
            {
                //if (slush > 6)
                  //  slushStep = 7;

                int upperValue =
                    dataSet.SlushCorrection[revThrust][keySlush + slushStep][keyWeight][keyPressAlt];
                float dSlush = slush - keySlush;
                float dSlushCorr = upperValue - baseSlushCorr;

                slushCorr += dSlush / slushStep * dSlushCorr;
            }

            if (pressAlt % pressAltStep != 0)
            {
                float dPressAlt = pressAlt - keyPressAlt;
                int upperValue =
                    dataSet.SlushCorrection[revThrust][keySlush][keyWeight][keyPressAlt + pressAltStep];
                float dSlushCorr = upperValue - baseSlushCorr;

                slushCorr += dPressAlt / pressAltStep * dSlushCorr;
            }

            if (weight % weightStep != 0)
            {
                float dWeight = weight - keyWeight;
                int upperValue =
                    dataSet.SlushCorrection[revThrust][keySlush][keyWeight + weightStep][keyPressAlt];
                float dSlushCorr = upperValue - baseSlushCorr;
                slushCorr += dWeight / weightStep * dSlushCorr;
            }

            return slushCorr;
        }

        private float CalculateBrakingActionCorrection(
            ITOPerformance dataSet,
            RunwayCondition brakingAction,
            ReverseThrust reverseThrust,
            float weight,
            float pressAlt)
        {
            if (reverseThrust == ReverseThrust.OneInop)
                reverseThrust = ReverseThrust.None;

            if (weight < 40 || weight > 90)
                throw new OutsideWeightEnvelopeException();

            if (pressAlt < -2 || pressAlt > 10)
                throw new OutsidePressAltEnvelopeException();

            if (brakingAction < RunwayCondition.Good ||
                brakingAction > RunwayCondition.Poor)
                throw new NotAllowedRunwayConditionException();

            if (pressAlt < 0)
                pressAlt = 0;

            int weightStep = 5;
            int pressAltStep = 5;
            int keyWeight = (int)weight / weightStep * weightStep;
            int keyPressAlt = (int)pressAlt / pressAltStep * pressAltStep;
            float baseBrakingActionCorr =
                dataSet.BrakingActionCorrection[reverseThrust][brakingAction][keyWeight][keyPressAlt];

            float brakingActionCorr = baseBrakingActionCorr;

            if (pressAlt % pressAltStep != 0)
            {
                float dPressAlt = pressAlt - pressAlt;
                int upperValue =
                    dataSet.BrakingActionCorrection[reverseThrust][brakingAction][keyWeight][keyPressAlt + pressAltStep];
                float dBrakingActionCorr = upperValue - baseBrakingActionCorr;

                brakingActionCorr += dPressAlt / pressAltStep * dBrakingActionCorr;
            }

            if (weight % weightStep != 0)
            {
                float dWeight = weight - keyWeight;
                int upperValue =
                    dataSet.BrakingActionCorrection[reverseThrust][brakingAction][keyWeight][keyPressAlt];
                float dBrakingActionCorr = upperValue - baseBrakingActionCorr;

                brakingActionCorr += dWeight / weightStep * dBrakingActionCorr;
            }

            return brakingActionCorr;
        }

        private float CalculateClearwayCorrection(
            ITOPerformance dataSet,
            int clearwayMStopway,
            float v1)
        {
            if (clearwayMStopway > 200 || clearwayMStopway < -300)
                throw new OutsideAllowedClearwayMinusStopwayRangeException();

            int clearwayStep = 100;
            int v1Step = 20;
            int keyClearwayMstopway = clearwayMStopway / clearwayStep * clearwayStep;
            int keyV1 = (int)v1 / v1Step * v1Step;

            if (keyV1 < 100)
                keyV1 = 100;
            else if (keyV1 > 160)
                keyV1 = 160;

            int baseClearwayCorr =
                dataSet.ClearwayCorrection[keyClearwayMstopway][keyV1];
            float clearwayCorr = baseClearwayCorr;

            if (clearwayMStopway % clearwayStep != 0)
            {
                if (clearwayMStopway < 0)
                    clearwayStep = -1 * clearwayStep;

                int upperValue =
                    dataSet.ClearwayCorrection[keyClearwayMstopway + clearwayStep][keyV1];
                float dClearwayMStopway =
                    clearwayMStopway - keyClearwayMstopway;
                int dClearwayCorr =
                    upperValue - baseClearwayCorr;

                clearwayCorr += dClearwayMStopway / Math.Abs(clearwayStep) * dClearwayCorr;
            }

            if (v1 % v1Step != 0)
            {
                int upperValue =
                    dataSet.ClearwayCorrection[keyClearwayMstopway][keyV1 + v1Step];
                float dV1 = (float)v1 - keyV1;
                float dClearwayCorr =
                    upperValue - baseClearwayCorr;

                clearwayCorr += dV1 / v1Step * dClearwayCorr;
            }

            return clearwayCorr;
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

            RunwayCondition rwyCondition = RunwayCondition.Dry;//parameters.RunwayCondition;

            /*if (parameters.RunwayCondition > RunwayCondition.Good ||
                parameters.RunwayCondition > RunwayCondition.Dry && parameters.ReverseThrust is ReverseThrust.None)
                rwyCondition = RunwayCondition.Dry;*/

            ITOPerformance dataSet = _dataSets[rwyCondition][parameters.Thrust];

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

            ITOPerformance dataSet = _dataSets[rwyCondition][parameters.Thrust];
            float vr = CalculateBaseVSpeed(VSpeed.Vr, parameters, dataSet);
            float vmcg =
                CalculateVmcg(dataSet, parameters.PressureAltitude, parameters.Temperature);

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

            ITOPerformance dataSet = _dataSets[rwyCondition][parameters.Thrust];

            float vr = CalculateBaseVSpeed(VSpeed.Vr, parameters, dataSet);

            float densAltCorr =
                CalculateDensAltCorrection(
                    dataSet,
                    parameters.Temperature,
                    parameters.PressureAltitude,
                    VSpeed.Vr);

            float adjustedVr = vr + densAltCorr;
            float vmcg =
                CalculateVmcg(dataSet, parameters.PressureAltitude, parameters.Temperature);

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

        private float CalculateBaseVSpeed(VSpeed vSpeed, TOParameters parameters, ITOPerformance dataSet)
        {
            if (parameters.Weight < 40 || parameters.Weight > 90)
                throw new OutsideWeightEnvelopeException();

            if (parameters.Temperature > 70 || parameters.Temperature < -60)
                throw new OutsideTempEnvelopeException();

            if (parameters.PressureAltitude < -2 || parameters.PressureAltitude > 10)
                throw new OutsidePressAltEnvelopeException();

            int weightStep = 5;
            int keyWeight = (int)parameters.Weight / weightStep * weightStep;
            float? v = dataSet.VSpeeds[parameters.Flaps][keyWeight][(int)vSpeed];

            if (v is null)
                throw new OutsideWeightEnvelopeException();

            if (parameters.Weight % weightStep != 0)
            {
                int? upperValue =
                    dataSet.VSpeeds[parameters.Flaps][keyWeight + weightStep][(int)vSpeed];

                if (upperValue is null)
                    throw new OutsideWeightEnvelopeException();

                float dWeight = parameters.Weight - keyWeight;
                float dSpeed = (int)upperValue - (float)v;

                v += dWeight / weightStep * dSpeed;
            }

            return (float)v;
        }
    }
}