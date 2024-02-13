namespace OPTCore.PerformanceCalculation
{
    public class DispatchException : Exception
    {
        public DispatchException(string? message)
            : base(message)
        {
        }
    }

    public class OutsideWeightEnvelopeException : DispatchException
    {
        public OutsideWeightEnvelopeException()
            : base("Weight is outside of allowed range.")
        {
        }
    }

    public class OutsideTempEnvelopeException : DispatchException
    {
        public OutsideTempEnvelopeException()
            : base("Temperature is outside of allowed range.")
        {
        }
    }

    public class OutsidePressAltEnvelopeException : DispatchException
    {
        public OutsidePressAltEnvelopeException()
            : base("Pressure altitude is outside of allowed range.")
        {
        }
    }

    public class OutsideSlopeEnvelopeException : DispatchException
    {
        public OutsideSlopeEnvelopeException()
            : base("Runway slope is outside of allowed range.")
        {
        }
    }

    public class OutsideHeadWindEnvelopeException : DispatchException
    {
        public OutsideHeadWindEnvelopeException()
            : base("Head wind component is outside of allowed range.")
        {
        }
    }

    public class OutsideDensAltEnvelopeException : DispatchException
    {
        public OutsideDensAltEnvelopeException()
            : base("Density altitude is outside of allowed range.")
        {
        }
    }

    public class OutsideAllowedSlushDepthException : DispatchException
    {
        public OutsideAllowedSlushDepthException()
            : base("Slush depth is outside of allowed range.")
        {
        }
    }

    public class OutsideAllowedClearwayMinusStopwayRangeException : DispatchException
    {
        public OutsideAllowedClearwayMinusStopwayRangeException()
            : base("Clearway minus stopway value is outside allowed range.")
        {
        }
    }

    public class InopAntiSkidNotAllowedException : DispatchException
    {
        public InopAntiSkidNotAllowedException()
            : base("Inoperative Anti-Skid is not allowed for provided take-off parameters.")
        {
        }
    }

    public class NotAllowedRunwayConditionException : DispatchException
    {
        public NotAllowedRunwayConditionException()
            : base("Selected runway condition is not allowed.")
        {
        }
    }
}
