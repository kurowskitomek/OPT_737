using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPTCore.AirfieldsData.Models
{
    public class Runway
    {
        public string? Designator { get; set; }
        public string? Surface { get; set; }
        public int TrueHeading { get; set; }
        public int Elevation { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int DisplacedThreshold { get; set; }
        public float Slope { get; set; }
        public bool Closed { get; set; }
        public bool Lighted { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int TORA { get; set; }
        public int ASDA { get; set; }
        public int LDA { get; set; }
        public int TODA { get; set; }
    }
}
