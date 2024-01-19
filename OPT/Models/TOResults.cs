using OPTCore.AirfieldsData.Models;
using OPTCore.PerformanceCalculation.Models;

namespace OPT.Models
{
    public class TOResults
    {
        public Runway? Runway { get; set; }
        public int V1 { get; set; }
        public int Vr { get; set; }
        public int V2 { get; set; }
        public int Vref40 { get; set; }
        public int TOGW { get; set; }
        public Flaps Flaps { get; set; }
    }
}
