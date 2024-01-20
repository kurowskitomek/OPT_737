using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPTCore.PerformanceCalculation.Models;

namespace OPTCore.PerformanceCalculation.Data
{
    public class TOPerfMax
    {
        public static readonly SortedList<int, SortedList<int, int>> Slush3V1CorrMaxRev = new()
        {
            { 90, new SortedList<int, int> { { 0, -15 }, { 5, -10 }, { 10, -5 } } },
            { 85, new SortedList<int, int> { { 0, -16 }, { 5, -11 }, { 10, -6 } } },
            { 80, new SortedList<int, int> { { 0, -18 }, { 5, -13 }, { 10, -8 } } },
            { 75, new SortedList<int, int> { { 0, -19 }, { 5, -14 }, { 10, -9 } } },
            { 70, new SortedList<int, int> { { 0, -20 }, { 5, -15 }, { 10, -10 } } },
            { 65, new SortedList<int, int> { { 0, -21 }, { 5, -16 }, { 10, -11 } } },
            { 60, new SortedList<int, int> { { 0, -22 }, { 5, -17 }, { 10, -12 } } },
            { 55, new SortedList<int, int> { { 0, -23 }, { 5, -18 }, { 10, -13 } } },
            { 50, new SortedList<int, int> { { 0, -24 }, { 5, -19 }, { 10, -14 } } },
            { 45, new SortedList<int, int> { { 0, -25 }, { 5, -20 }, { 10, -15 } } },
            { 40, new SortedList<int, int> { { 0, -25 }, { 5, -20 }, { 10, -15 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> Slush6V1CorrMaxRev = new()
        {
            { 90, new SortedList<int, int> { { 0, -7 },     { 5, -2 },  { 10, 0 } } },
            { 85, new SortedList<int, int> { { 0, -10 },    { 5, -5 },  { 10, 0 } } },
            { 80, new SortedList<int, int> { { 0, -12 },    { 5, -7 },  { 10, -2 } } },
            { 75, new SortedList<int, int> { { 0, -14 },    { 5, -9 },  { 10, -4 } } },
            { 70, new SortedList<int, int> { { 0, -16 },    { 5, -11 }, { 10, -6 } } },
            { 65, new SortedList<int, int> { { 0, -17 },    { 5, -12 }, { 10, -7 } } },
            { 60, new SortedList<int, int> { { 0, -19 },    { 5, -14 }, { 10, -9 } } },
            { 55, new SortedList<int, int> { { 0, -20 },    { 5, -15 }, { 10, -10 } } },
            { 50, new SortedList<int, int> { { 0, -22 },    { 5, -17 }, { 10, -12 } } },
            { 45, new SortedList<int, int> { { 0, -23 },    { 5, -18 }, { 10, -13 } } },
            { 40, new SortedList<int, int> { { 0, -24 },    { 5, -19 }, { 10, -14 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> Slush13V1CorrMaxRev = new()
        {
            { 90, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 85, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 80, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 75, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 70, new SortedList<int, int> { { 0, -4 },     { 5, 0 },   { 10, 0 } } },
            { 65, new SortedList<int, int> { { 0, -8 },     { 5, -3 },  { 10, 0 } } },
            { 60, new SortedList<int, int> { { 0, -11 },    { 5, -6 },  { 10, -1 } } },
            { 55, new SortedList<int, int> { { 0, -14 },    { 5, -9 },  { 10, -4 } } },
            { 50, new SortedList<int, int> { { 0, -17 },    { 5, -12 }, { 10, -7 } } },
            { 45, new SortedList<int, int> { { 0, -19 },    { 5, -14 }, { 10, -9 } } },
            { 40, new SortedList<int, int> { { 0, -21 },    { 5, -16 }, { 10, -11 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> Slush3V1CorrNoRev = new()
        {
            { 90, new SortedList<int, int> { { 0, -20 }, { 5, -10 }, { 10, -0 } } },
            { 85, new SortedList<int, int> { { 0, -22 }, { 5, -12 }, { 10, -2 } } },
            { 80, new SortedList<int, int> { { 0, -24 }, { 5, -14 }, { 10, -4 } } },
            { 75, new SortedList<int, int> { { 0, -25 }, { 5, -15 }, { 10, -5 } } },
            { 70, new SortedList<int, int> { { 0, -27 }, { 5, -17 }, { 10, -7 } } },
            { 65, new SortedList<int, int> { { 0, -28 }, { 5, -18 }, { 10, -8 } } },
            { 60, new SortedList<int, int> { { 0, -29 }, { 5, -19 }, { 10, -9 } } },
            { 55, new SortedList<int, int> { { 0, -30 }, { 5, -20 }, { 10, -10 } } },
            { 50, new SortedList<int, int> { { 0, -31 }, { 5, -21 }, { 10, -11 } } },
            { 45, new SortedList<int, int> { { 0, -32 }, { 5, -22 }, { 10, -12 } } },
            { 40, new SortedList<int, int> { { 0, -32 }, { 5, -22 }, { 10, -12 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> Slush6V1CorrNoRev = new()
        {
            { 90, new SortedList<int, int> { { 0, -11 }, { 5, -1 },     { 10, 0 } } },
            { 85, new SortedList<int, int> { { 0, -14 }, { 5, -4 },     { 10, 0 } } },
            { 80, new SortedList<int, int> { { 0, -16 }, { 5, -6 },     { 10, 0 } } },
            { 75, new SortedList<int, int> { { 0, -19 }, { 5, -9 },     { 10, 0 } } },
            { 70, new SortedList<int, int> { { 0, -21 }, { 5, -11 },    { 10, -1 } } },
            { 65, new SortedList<int, int> { { 0, -23 }, { 5, -13 },    { 10, -3 } } },
            { 60, new SortedList<int, int> { { 0, -25 }, { 5, -15 },    { 10, -5 } } },
            { 55, new SortedList<int, int> { { 0, -27 }, { 5, -17 },    { 10, -7 } } },
            { 50, new SortedList<int, int> { { 0, -28 }, { 5, -18 },    { 10, -8 } } },
            { 45, new SortedList<int, int> { { 0, -30 }, { 5, -20 },    { 10, -10 } } },
            { 40, new SortedList<int, int> { { 0, -31 }, { 5, -21 },    { 10, -11 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> Slush13V1CorrNoRev = new()
        {
            { 90, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 85, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 80, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 75, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 70, new SortedList<int, int> { { 0, -6 },     { 5, 0 },   { 10, 0 } } },
            { 65, new SortedList<int, int> { { 0, -11 },    { 5, -1 },  { 10, 0 } } },
            { 60, new SortedList<int, int> { { 0, -15 },    { 5, -5 },  { 10, 0 } } },
            { 55, new SortedList<int, int> { { 0, -19 },    { 5, -9 },  { 10, 0 } } },
            { 50, new SortedList<int, int> { { 0, -22 },    { 5, -12 }, { 10, -2 } } },
            { 45, new SortedList<int, int> { { 0, -25 },    { 5, -15 }, { 10, -5 } } },
            { 40, new SortedList<int, int> { { 0, -27 },    { 5, -17 }, { 10, -7 } } }
        };

        public static readonly SortedList<int, SortedList<int, SortedList<int, int>>> SlushNoRev = new()
        {
            { 3, Slush3V1CorrNoRev },
            { 6, Slush6V1CorrNoRev },
            { 13, Slush13V1CorrNoRev }
        };

        public static readonly SortedList<int, SortedList<int, SortedList<int, int>>> SlushMaxRev = new()
        {
            { 3, Slush3V1CorrMaxRev },
            { 6, Slush6V1CorrMaxRev },
            { 13, Slush13V1CorrMaxRev }
        };

        public static readonly SortedList<int, SortedList<int, int>> GoodV1CorrMaxRev = new()
        {
            { 90, new SortedList<int, int> { { 0, -5 },     { 5, -2 },  { 10, 0 } } },
            { 85, new SortedList<int, int> { { 0, -6 },     { 5, -3 },  { 10, -1 } } },
            { 80, new SortedList<int, int> { { 0, -7 },     { 5, -4 },  { 10, -2 } } },
            { 75, new SortedList<int, int> { { 0, -8 },     { 5, -5 },  { 10, -3 } } },
            { 70, new SortedList<int, int> { { 0, -9 },     { 5, -6 },  { 10, -4 } } },
            { 65, new SortedList<int, int> { { 0, -9 },     { 5, -7 },  { 10, -4 } } },
            { 60, new SortedList<int, int> { { 0, -10 },    { 5, -8 },  { 10, -5 } } },
            { 55, new SortedList<int, int> { { 0, -11 },    { 5, -9 },  { 10, -6 } } },
            { 50, new SortedList<int, int> { { 0, -12 },    { 5, -9 },  { 10, -7 } } },
            { 45, new SortedList<int, int> { { 0, -13 },    { 5, -10 }, { 10, -8 } } },
            { 40, new SortedList<int, int> { { 0, -14 },    { 5, -11 }, { 10, -9 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> MediumV1CorrMaxRev = new()
        {
            { 90, new SortedList<int, int> { { 0, -13 }, { 5, -11 }, { 10, -8 } } },
            { 85, new SortedList<int, int> { { 0, -15 }, { 5, -13 }, { 10, -10 } } },
            { 80, new SortedList<int, int> { { 0, -17 }, { 5, -14 }, { 10, -12 } } },
            { 75, new SortedList<int, int> { { 0, -18 }, { 5, -16 }, { 10, -13 } } },
            { 70, new SortedList<int, int> { { 0, -20 }, { 5, -17 }, { 10, -15 } } },
            { 65, new SortedList<int, int> { { 0, -21 }, { 5, -19 }, { 10, -16 } } },
            { 60, new SortedList<int, int> { { 0, -22 }, { 5, -20 }, { 10, -17 } } },
            { 55, new SortedList<int, int> { { 0, -24 }, { 5, -21 }, { 10, -19 } } },
            { 50, new SortedList<int, int> { { 0, -25 }, { 5, -22 }, { 10, -20 } } },
            { 45, new SortedList<int, int> { { 0, -26 }, { 5, -24 }, { 10, -21 } } },
            { 40, new SortedList<int, int> { { 0, -27 }, { 5, -25 }, { 10, -22 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> PoorV1CorrMaxRev = new()
        {
            { 90, new SortedList<int, int> { { 0, -25 }, { 5, -23 }, { 10, -20 } } },
            { 85, new SortedList<int, int> { { 0, -27 }, { 5, -24 }, { 10, -22 } } },
            { 80, new SortedList<int, int> { { 0, -29 }, { 5, -26 }, { 10, -24 } } },
            { 75, new SortedList<int, int> { { 0, -31 }, { 5, -28 }, { 10, -26 } } },
            { 70, new SortedList<int, int> { { 0, -33 }, { 5, -30 }, { 10, -28 } } },
            { 65, new SortedList<int, int> { { 0, -35 }, { 5, -32 }, { 10, -30 } } },
            { 60, new SortedList<int, int> { { 0, -37 }, { 5, -34 }, { 10, -32 } } },
            { 55, new SortedList<int, int> { { 0, -38 }, { 5, -36 }, { 10, -33 } } },
            { 50, new SortedList<int, int> { { 0, -40 }, { 5, -37 }, { 10, -35 } } },
            { 45, new SortedList<int, int> { { 0, -41 }, { 5, -39 }, { 10, -36 } } },
            { 40, new SortedList<int, int> { { 0, -42 }, { 5, -40 }, { 10, -37 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> GoodV1CorrNoRev = new()
        {
            { 90, new SortedList<int, int> { { 0, -7 },     { 5, -2 },  { 10, 0 } } },
            { 85, new SortedList<int, int> { { 0, -8 },     { 5, -3 },  { 10, 0 } } },
            { 80, new SortedList<int, int> { { 0, -9 },     { 5, -4 },  { 10, 0 } } },
            { 75, new SortedList<int, int> { { 0, -11 },    { 5, -6 },  { 10, -1 } } },
            { 70, new SortedList<int, int> { { 0, -12 },    { 5, -7 },  { 10, -2 } } },
            { 65, new SortedList<int, int> { { 0, -14 },    { 5, -9 },  { 10, -4 } } },
            { 60, new SortedList<int, int> { { 0, -15 },    { 5, -10 }, { 10, -5 } } },
            { 55, new SortedList<int, int> { { 0, -17 },    { 5, -12 }, { 10, -7 } } },
            { 50, new SortedList<int, int> { { 0, -18 },    { 5, -13 }, { 10, -8 } } },
            { 45, new SortedList<int, int> { { 0, -20 },    { 5, -15 }, { 10, -10 } } },
            { 40, new SortedList<int, int> { { 0, -22 },    { 5, -17 }, { 10, -12 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> MediumV1CorrNoRev = new()
        {
            { 90, new SortedList<int, int> { { 0, -19 }, { 5, -14 }, { 10, -9 } } },
            { 85, new SortedList<int, int> { { 0, -21 }, { 5, -16 }, { 10, -11 } } },
            { 80, new SortedList<int, int> { { 0, -24 }, { 5, -19 }, { 10, -14 } } },
            { 75, new SortedList<int, int> { { 0, -26 }, { 5, -21 }, { 10, -16 } } },
            { 70, new SortedList<int, int> { { 0, -28 }, { 5, -23 }, { 10, -18 } } },
            { 65, new SortedList<int, int> { { 0, -31 }, { 5, -26 }, { 10, -21 } } },
            { 60, new SortedList<int, int> { { 0, -34 }, { 5, -29 }, { 10, -24 } } },
            { 55, new SortedList<int, int> { { 0, -37 }, { 5, -32 }, { 10, -27 } } },
            { 50, new SortedList<int, int> { { 0, -40 }, { 5, -35 }, { 10, -30 } } },
            { 45, new SortedList<int, int> { { 0, -43 }, { 5, -38 }, { 10, -33 } } },
            { 40, new SortedList<int, int> { { 0, -46 }, { 5, -41 }, { 10, -36 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> PoorV1CorrNoRev = new()
        {
            { 90, new SortedList<int, int> { { 0, -39 }, { 5, -34 }, { 10, -29 } } },
            { 85, new SortedList<int, int> { { 0, -42 }, { 5, -37 }, { 10, -32 } } },
            { 80, new SortedList<int, int> { { 0, -45 }, { 5, -40 }, { 10, -35 } } },
            { 75, new SortedList<int, int> { { 0, -49 }, { 5, -44 }, { 10, -39 } } },
            { 70, new SortedList<int, int> { { 0, -52 }, { 5, -47 }, { 10, -42 } } },
            { 65, new SortedList<int, int> { { 0, -56 }, { 5, -51 }, { 10, -46 } } },
            { 60, new SortedList<int, int> { { 0, -59 }, { 5, -54 }, { 10, -49 } } },
            { 55, new SortedList<int, int> { { 0, -63 }, { 5, -58 }, { 10, -53 } } },
            { 50, new SortedList<int, int> { { 0, -66 }, { 5, -61 }, { 10, -56 } } },
            { 45, new SortedList<int, int> { { 0, -70 }, { 5, -65 }, { 10, -60 } } },
            { 40, new SortedList<int, int> { { 0, -74 }, { 5, -69 }, { 10, -64 } } }
        };

        public static readonly Dictionary<RunwayCondition, SortedList<int, SortedList<int, int>>> SlipperyNoRev = new()
        {
            { RunwayCondition.Good, GoodV1CorrNoRev },
            { RunwayCondition.Medium, MediumV1CorrNoRev },
            { RunwayCondition.Poor, PoorV1CorrNoRev }
        };

        public static readonly Dictionary<RunwayCondition, SortedList<int, SortedList<int, int>>> SlipperyMaxRev = new()
        {
            { RunwayCondition.Good, GoodV1CorrMaxRev },
            { RunwayCondition.Medium, MediumV1CorrMaxRev },
            { RunwayCondition.Poor, PoorV1CorrMaxRev }
        };

        public static readonly SortedList<int, int?[]> Flaps1VSpeeds = new()
        {
            { 90, new int?[] { 169, 171, 175 } },
            { 85, new int?[] { 163, 166, 171 } },
            { 80, new int?[] { 158, 160, 167 } },
            { 75, new int?[] { 153, 155, 162 } },
            { 70, new int?[] { 147, 149, 158 } },
            { 65, new int?[] { 141, 143, 153 } },
            { 60, new int?[] { 135, 136, 148 } },
            { 55, new int?[] { 128, 129, 143 } },
            { 50, new int?[] { 121, 122, 137 } },
            { 45, new int?[] { 113, 114, 131 } },
            { 40, new int?[] { 105, 106, 125 } }
        };

        public static readonly SortedList<int, int?[]> Flaps5VSpeeds = new()
        {
            { 90, new int?[] { 161, 163, 168 } },
            { 85, new int?[] { 157, 159, 164 } },
            { 80, new int?[] { 152, 154, 160 } },
            { 75, new int?[] { 147, 148, 156 } },
            { 70, new int?[] { 141, 143, 152 } },
            { 65, new int?[] { 135, 137, 147 } },
            { 60, new int?[] { 129, 131, 143 } },
            { 55, new int?[] { 123, 124, 137 } },
            { 50, new int?[] { 116, 117, 132 } },
            { 45, new int?[] { 109, 110, 126 } },
            { 40, new int?[] { 101, 102, 120 } }
        };

        public static readonly SortedList<int, int?[]> Flaps10VSpeeds = new()
        {
            { 90, new int?[] { null, null, null } },
            { 85, new int?[] { 156, 157, 162 } },
            { 80, new int?[] { 151, 152, 158 } },
            { 75, new int?[] { 146, 147, 154 } },
            { 70, new int?[] { 140, 141, 150 } },
            { 65, new int?[] { 134, 136, 146 } },
            { 60, new int?[] { 128, 129, 141 } },
            { 55, new int?[] { 122, 123, 136 } },
            { 50, new int?[] { 115, 116, 130 } },
            { 45, new int?[] { 108, 108, 125 } },
            { 40, new int?[] { 100, 101, 119 } }
        };

        public static readonly SortedList<int, int?[]> Flaps15VSpeeds = new()
        {
            { 90, new int?[] { null, null, null } },
            { 85, new int?[] { null, null, null } },
            { 80, new int?[] { 148, 149, 155 } },
            { 75, new int?[] { 142, 144, 151 } },
            { 70, new int?[] { 137, 138, 147 } },
            { 65, new int?[] { 131, 133, 143 } },
            { 60, new int?[] { 125, 126, 138 } },
            { 55, new int?[] { 119, 120, 133 } },
            { 50, new int?[] { 112, 113, 128 } },
            { 45, new int?[] { 105, 106, 122 } },
            { 40, new int?[] { 98,  99, 117 } }
        };

        public static readonly SortedList<int, int?[]> Flaps25VSpeeds = new()
        {
            { 90, new int?[] { null, null, null } },
            { 85, new int?[] { null, null, null } },
            { 80, new int?[] { 145, 146, 153 } },
            { 75, new int?[] { 140, 141, 149 } },
            { 70, new int?[] { 135, 136, 145 } },
            { 65, new int?[] { 129, 130, 140 } },
            { 60, new int?[] { 123, 124, 136 } },
            { 55, new int?[] { 117, 118, 131 } },
            { 50, new int?[] { 110, 111, 126 } },
            { 45, new int?[] { 103, 104, 120 } },
            { 40, new int?[] { 96,  97, 115 } }
        };

        public static readonly SortedList<int, SortedList<int, int?>> DensAltCorrV1 = new()
        {
            { 70,   new SortedList<int, int?> { { -2, 5 }, { 0, 6 }, { 2, null },   { 4, null },    { 6, null },    { 8, null },    { 10, null } } },
            { 60,   new SortedList<int, int?> { { -2, 4 }, { 0, 5 }, { 2, 6 },      { 4, 7 },       { 6, null },    { 8, null },    { 10, null } } },
            { 50,   new SortedList<int, int?> { { -2, 2 }, { 0, 3 }, { 2, 4 },      { 4, 5 },       { 6, 6 },       { 8, 7 },       { 10, 9 } } },
            { 40,   new SortedList<int, int?> { { -2, 1 }, { 0, 1 }, { 2, 3 },      { 4, 4 },       { 6, 5 },       { 8, 6 },       { 10, 7 } } },
            { 30,   new SortedList<int, int?> { { -2, 0 }, { 0, 0 }, { 2, 1 },      { 4, 2 },       { 6, 4 },       { 8, 5 },       { 10, 6 } } },
            { 20,   new SortedList<int, int?> { { -2, 0 }, { 0, 0 }, { 2, 1 },      { 4, 2 },       { 6, 3 },       { 8, 4 },       { 10, 5 } } },
            { -60,  new SortedList<int, int?> { { -2, 0 }, { 0, 0 }, { 2, 1 },      { 4, 2 },       { 6, 3 },       { 8, 4 },       { 10, 5 } } }
        };

        public static readonly SortedList<int, SortedList<int, int?>> DensAltCorrVr = new()
        {
            { 70,   new SortedList<int, int?> { { -2, 4 }, { 0, 5 }, { 2, null },   { 4, null },    { 6, null },    { 8, null },    { 10, null } } },
            { 60,   new SortedList<int, int?> { { -2, 3 }, { 0, 4 }, { 2, 5 },      { 4, 6 },       { 6, null },    { 8, null },    { 10, null } } },
            { 50,   new SortedList<int, int?> { { -2, 2 }, { 0, 3 }, { 2, 4 },      { 4, 5 },       { 6, 6 },       { 8, 7 },       { 10, 8 } } },
            { 40,   new SortedList<int, int?> { { -2, 1 }, { 0, 1 }, { 2, 3 },      { 4, 4 },       { 6, 5 },       { 8, 6 },       { 10, 7 } } },
            { 30,   new SortedList<int, int?> { { -2, 0 }, { 0, 0 }, { 2, 1 },      { 4, 3 },       { 6, 4 },       { 8, 5 },       { 10, 6 } } },
            { 20,   new SortedList<int, int?> { { -2, 0 }, { 0, 0 }, { 2, 1 },      { 4, 2 },       { 6, 3 },       { 8, 4 },       { 10, 5 } } },
            { -60,  new SortedList<int, int?> { { -2, 0 }, { 0, 0 }, { 2, 1 },      { 4, 2 },       { 6, 3 },       { 8, 4 },       { 10, 5 } } }
        };

        public static readonly SortedList<int, SortedList<int, int?>> DensAltCorrV2 = new()
        {
            { 70,   new SortedList<int, int?> { { -2, -3 },   { 0, -3 },  { 2, null },    { 4, null },    { 6, null },    { 8, null },    { 10, null } } },
            { 60,   new SortedList<int, int?> { { -2, -2 },   { 0, -3 },  { 2, -3 },      { 4, -4 },      { 6, null },    { 8, null },    { 10, null } } },
            { 50,   new SortedList<int, int?> { { -2, -2 },   { 0, -2 },  { 2, -3 },      { 4, -3 },      { 6, -4 },      { 8, -5 },      { 10, -6 } } },
            { 40,   new SortedList<int, int?> { { -2, -1 },   { 0, -1 },  { 2, -2 },      { 4, -2 },      { 6, -3 },      { 8, -4 },      { 10, -5 } } },
            { 30,   new SortedList<int, int?> { { -2, 0 },    { 0, 0 },   { 2, -1 },      { 4, -2 },      { 6, -2 },      { 8, -3 },      { 10, -4 } } },
            { 20,   new SortedList<int, int?> { { -2, 0 },    { 0, 0 },   { 2, -1 },      { 4, -1 },      { 6, -2 },      { 8, -3 },      { 10, -3 } } },
            { -60,  new SortedList<int, int?> { { -2, 0 },    { 0, 0 },   { 2, -1 },      { 4, -1 },      { 6, -2 },      { 8, -2 },      { 10, -3 } } }
        };

        public static readonly Dictionary<Flaps, SortedList<int, int?[]>> VSpeeds = new()
        {
            { Flaps.Flaps1, Flaps1VSpeeds },
            { Flaps.Flaps5, Flaps5VSpeeds },
            { Flaps.Flaps10, Flaps10VSpeeds },
            { Flaps.Flaps15, Flaps15VSpeeds },
            { Flaps.Flaps25, Flaps25VSpeeds }
        };

        public static readonly SortedList<int, SortedList<int, int?>>[] DensAltCorr =
        [
            DensAltCorrV1,
            DensAltCorrVr,
            DensAltCorrV2
        ];

        public static readonly SortedList<int, SortedList<int, int>> SlopeCorr = new()         
        {
            { 90, new SortedList<int, int> { { -2, -4 },    { -1, -2 }, { 0, 0 }, { 1, 1 }, { 2, 1 } } },
            { 80, new SortedList<int, int> { { -2, -3 },    { -1, -2 }, { 0, 0 }, { 1, 1 }, { 2, 1 } } },
            { 70, new SortedList<int, int> { { -2, -2 },    { -1, -1 }, { 0, 0 }, { 1, 1 }, { 2, 1 } } },
            { 60, new SortedList<int, int> { { -2, -2 },    { -1, -1 }, { 0, 0 }, { 1, 1 }, { 2, 1 } } },
            { 50, new SortedList<int, int> { { -2, -1 },    { -1, 0 },  { 0, 0 }, { 1, 0 }, { 2, 1 } } },
            { 40, new SortedList<int, int> { { -2, 0 },     { -1, 0 },  { 0, 0 }, { 1, 0 }, { 2, 0 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> WindCorr = new()            
        {
            { 90, new SortedList<int, int> { { -15, -2 }, { -10, -2 }, { -5, -1 },  { 0, 0 }, { 10, 0 }, { 20, 0 }, { 30, 0 }, { 40, 1 } } },
            { 80, new SortedList<int, int> { { -15, -2 }, { -10, -1 }, { -5, -1 },  { 0, 0 }, { 10, 0 }, { 20, 0 }, { 30, 1 }, { 40, 1 } } },
            { 70, new SortedList<int, int> { { -15, -2 }, { -10, -1 }, { -5, -1 },  { 0, 0 }, { 10, 0 }, { 20, 1 }, { 30, 1 }, { 40, 1 } } },
            { 60, new SortedList<int, int> { { -15, -2 }, { -10, -1 }, { -5, -1 },  { 0, 0 }, { 10, 0 }, { 20, 1 }, { 30, 1 }, { 40, 1 } } },
            { 50, new SortedList<int, int> { { -15, -2 }, { -10, -1 }, { -5, 0 },   { 0, 0 }, { 10, 0 }, { 20, 1 }, { 30, 1 }, { 40, 1 } } },
            { 40, new SortedList<int, int> { { -15, -2 }, { -10, -1 }, { -5, 0 },   { 0, 0 }, { 10, 0 }, { 20, 0 }, { 30, 0 }, { 40, 0 } } }
        };

        public static readonly SortedList<int, SortedList<int, int?>> Vmcg = new()            
        {
            { 70,   new SortedList<int, int?> { { -2, 95 },  { 0, 93 },  { 2, null }, { 4, null }, { 6, null }, { 8, null }, { 10, null } } },
            { 60,   new SortedList<int, int?> { { -2, 95 },  { 0, 93 },  { 2, 92 },   { 4, 90 },   { 6, null }, { 8, null }, { 10, null } } },
            { 50,   new SortedList<int, int?> { { -2, 97 },  { 0, 95 },  { 2, 92 },   { 4, 90 },   { 6, 88 },   { 8, 86 },   { 10, 83 } } },
            { 40,   new SortedList<int, int?> { { -2, 101 }, { 0, 99 },  { 2, 96 },   { 4, 93 },   { 6, 89 },   { 8, 86 },   { 10, 83 } } },
            { 30,   new SortedList<int, int?> { { -2, 104 }, { 0, 103 }, { 2, 100 },  { 4, 96 },   { 6, 92 },   { 8, 88 },   { 10, 85 } } },
            { 20,   new SortedList<int, int?> { { -2, 104 }, { 0, 104 }, { 2, 101 },  { 4, 98 },   { 6, 94 },   { 8, 90 },   { 10, 87 } } },
            { -60,  new SortedList<int, int?> { { -2, 106 }, { 0, 105 }, { 2, 102 },  { 4, 99 },   { 6, 95 },   { 8, 92 },   { 10, 89 } } },
        };

        public static readonly SortedList<int, SortedList<int, int>> ClearwayCorr = new()
        {
            { 200,  new SortedList<int, int> { { 100, -5 }, { 120, -4 },    { 140, -3 },    { 160, -3 } } },
            { 100,  new SortedList<int, int> { { 100, -3 }, { 120, -2 },    { 140, -2 },    { 160, -2 } } },
            { 0,    new SortedList<int, int> { { 100,  0 }, { 120, 0 },     { 140, 0 },     { 160, 0 } } },
            { -100, new SortedList<int, int> { { 100, 1 },  { 120, 1 },     { 140, 1 },     { 160, 1 } } },
            { -200, new SortedList<int, int> { { 100, 1 },  { 120, 1 },     { 140, 1 },     { 160, 1 } } },
            { -300, new SortedList<int, int> { { 100, 1 },  { 120, 1 },     { 140, 1 },     { 160, 1 } } }
        };

        public static readonly Dictionary<ReverseThrust, Dictionary<RunwayCondition, SortedList<int, SortedList<int, int>>>> SlipperyV1Corr = new()
        {
            { ReverseThrust.Max, SlipperyMaxRev },
            { ReverseThrust.None, SlipperyNoRev }
        };

        public static readonly Dictionary<ReverseThrust, SortedList<int, SortedList<int, SortedList<int, int>>>> SlushV1Corr = new()
        {
            { ReverseThrust.Max, SlushMaxRev },
            { ReverseThrust.None, SlushNoRev }
        };

        public static readonly SortedList<int, int> AntiSkidCorr = new()
        {
            { 2000, -19 },
            { 2500, -16 },
            { 3000, -14 },
            { 3500, -12 },
            { 4000, -11 }
        };
    }
}
