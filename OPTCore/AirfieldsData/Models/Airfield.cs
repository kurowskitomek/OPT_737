using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPTCore.AirfieldsData.Models
{
    public class Airfield
    {
        public string? ICAOCode { get; set; }
        public List<Runway>? Runways { get; set; }
    }
}
