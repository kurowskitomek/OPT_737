using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPTCore.PerformanceCalculation.Models
{
    public enum VSpeed
    {
        V1,
        Vr,
        V2
    }

    public enum AntiSkid
    {
        Operative,
        Inop
    }

    public enum TOThrust
    {
        Max,
        Derate24K,
        Derate22K
    }

    public enum RunwayCondition
    {
        Dry,
        Good,
        Medium,
        Poor,
        Slush
    }

    public enum ReverseThrust
    {
        Max,
        OneInop,
        None
    }

    public enum Flaps
    {
        Flaps1,
        Flaps5,
        Flaps10,
        Flaps15,
        Flaps25
    }

    public enum AirCond
    {
        Off,
        On
    }

    public enum AntiIce
    {
        Off,
        Eng,
        Eng_Wing
    }

    public class TOParameters
    {
        public TOThrust Thrust { get; set; }
        public RunwayCondition RunwayCondition { get; set; }
        public Flaps Flaps { get; set; }
        public ReverseThrust ReverseThrust { get; set; }
        public AntiSkid AntiSkid { get; set; }
        public AirCond AirCond { get; set; }
        public AntiIce AntiIce { get; set; }
        public int Slush { get; set; }
        public float Weight { get; set; }
        public int Temperature { get; set; }
        public float PressureAltitude { get; set; }
        public float RunwaySlope { get; set; }
        public int HeadWind { get; set; }
        public int ClearwayMStopway { get; set; }
        public int RunwayLength { get; set; }
    }
}
