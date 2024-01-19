using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPTCore.WeatherData.Models
{
    public class Metar
    {
        private const float KmToSM = 1.60934f;

        public int? Metar_Id { get; set; }
        public string? IcaoId { get; set; }
        public DateTime? ReceiptTime { get; set; }
        public int? ObsTime { get; set; }
        public DateTime? ReportTime { get; set; }
        public float? Temp { get; set; }
        public float? Dewp { get; set; }
        public string? Wdir { get; set; }

        public int? WdirInt
        {
            get
            {
                if (int.TryParse(Wdir, out var value))
                    return value;

                return null;
            }
        }

        public int? Wspd { get; set; }
        public int? Wgst { get; set; }
        public string? Visib { get; set; }

        public float? VisibKm
        {
            get
            {
                if (Visib is null)
                    return null;

                string visibStr = Visib.Replace("+", "");

                if (float.TryParse(visibStr, CultureInfo.InvariantCulture, out var value))
                {
                    float visib = (float)Math.Round(value * KmToSM, 1);

                    if (visib >= 9.65)
                        visib = 10;

                    return visib;
                }

                return null;
            }
        }

        public float? Altim { get; set; }
        public float? Slp { get; set; }
        public int? QcField { get; set; }
        public string? WxString { get; set; }
        public float? PresTend { get; set; }
        public float? MaxT { get; set; }
        public float? MinT { get; set; }
        public float? MaxT24 { get; set; }
        public float? MinT24 { get; set; }
        public float? Precip { get; set; }
        public float? Snow { get; set; }
        public int? VertVis { get; set; }
        public string? MetarType { get; set; }
        public string? RawOb { get; set; }
        public bool? MostRecent { get; set; }
        public float? Lat { get; set; }
        public float? Lon { get; set; }
        public int? Elev { get; set; }
        public int? Prior { get; set; }
        public string? Name { get; set; }
        public IEnumerable<Clouds>? Clouds { get; set; }
    }
}
