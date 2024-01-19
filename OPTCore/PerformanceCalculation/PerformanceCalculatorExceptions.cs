namespace OPTCore.PerformanceCalculation
{
    public class OutsideWeightEnvelopeException : Exception
    {
        public OutsideWeightEnvelopeException()
            : base("Weight is outside of allowed range.")
        {
        }
    }

    public class OutsideTempEnvelopeException : Exception
    {
        public OutsideTempEnvelopeException()
            : base("Temperature is outside of allowed range.")
        {
        }
    }

    public class OutsidePressAltEnvelopeException : Exception
    {
        public OutsidePressAltEnvelopeException()
            : base("Pressure altitude is outside of allowed range.")
        {
        }
    }

    public class OutsideSlopeEnvelopeException : Exception
    {
        public OutsideSlopeEnvelopeException()
            : base("Runway slope is outside of allowed range.")
        {
        }
    }

    public class OutsideWindEnvelopeException : Exception
    {
        public OutsideWindEnvelopeException()
            : base("Wind velocity is outside of allowed range.")
        {
        }
    }

    public class OutsideDensAltEnvelopeException : Exception
    {
        public OutsideDensAltEnvelopeException()
            : base("Density altitude is outside of allowed range.")
        {
        }
    }

    public class OutsideAllowedSlushDepthException : Exception
    {
        public OutsideAllowedSlushDepthException()
            : base("Slush depth is outside of allowed range.")
        {
        }
    }

    public class OutsideAllowedClearwayMinusStopwayRangeException : Exception
    {
        public OutsideAllowedClearwayMinusStopwayRangeException()
            : base("Clearway minus stopway value is outside allowed range.")
        {
        }
    }

    public class InopAntiSkidNotAllowedException : Exception
    {
        public InopAntiSkidNotAllowedException()
            : base("Inoperative Anti-Skid is not allowed for provided take-off parameters.")
        {
        }
    }

    public class NotAllowedRunwayConditionException : Exception
    {
        public NotAllowedRunwayConditionException()
            : base("Selected runway condition is not allowed.")
        {
        }
    }
}
