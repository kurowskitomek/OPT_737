using OPTCore.PerformanceCalculation.Models;

namespace OPTCore.PerformanceCalculation.Data
{
    public class TOPerf24K
    {
        public static readonly SortedList<int, SortedList<int, int>> Slush3V1CorrMaxRev = new()
        {
            { 90, new SortedList<int, int> { { 0, -13 }, { 5, -11 }, { 10, -8 } } },
            { 85, new SortedList<int, int> { { 0, -14 }, { 5, -12 }, { 10, -9 } } },
            { 80, new SortedList<int, int> { { 0, -15 }, { 5, -13 }, { 10, -10 } } },
            { 75, new SortedList<int, int> { { 0, -17 }, { 5, -14 }, { 10, -12 } } },
            { 70, new SortedList<int, int> { { 0, -18 }, { 5, -15 }, { 10, -13 } } },
            { 65, new SortedList<int, int> { { 0, -19 }, { 5, -16 }, { 10, -14 } } },
            { 60, new SortedList<int, int> { { 0, -20 }, { 5, -18 }, { 10, -15 } } },
            { 55, new SortedList<int, int> { { 0, -22 }, { 5, -19 }, { 10, -17 } } },
            { 50, new SortedList<int, int> { { 0, -22 }, { 5, -20 }, { 10, -17 } } },
            { 45, new SortedList<int, int> { { 0, -23 }, { 5, -20 }, { 10, -18 } } },
            { 40, new SortedList<int, int> { { 0, -23 }, { 5, -20 }, { 10, -18 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> Slush6V1CorrMaxRev = new()
        {
            { 90, new SortedList<int, int> { { 0, -7 },     { 5, -5 },  { 10, -2 } } },
            { 85, new SortedList<int, int> { { 0, -8 },     { 5, -6 },  { 10, -3 } } },
            { 80, new SortedList<int, int> { { 0, -9 },     { 5, -7 },  { 10, -4 } } },
            { 75, new SortedList<int, int> { { 0, -11 },    { 5, -8 },  { 10, -6 } } },
            { 70, new SortedList<int, int> { { 0, -12 },    { 5, -10 }, { 10, -7 } } },
            { 65, new SortedList<int, int> { { 0, -14 },    { 5, -12 }, { 10, -9 } } },
            { 60, new SortedList<int, int> { { 0, -16 },    { 5, -14 }, { 10, -11 } } },
            { 55, new SortedList<int, int> { { 0, -19 },    { 5, -16 }, { 10, -14 } } },
            { 50, new SortedList<int, int> { { 0, -20 },    { 5, -18 }, { 10, -15 } } },
            { 45, new SortedList<int, int> { { 0, -21 },    { 5, -18 }, { 10, -16 } } },
            { 40, new SortedList<int, int> { { 0, -21 },    { 5, -18 }, { 10, -16 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> Slush13V1CorrMaxRev = new()
        {
            { 90, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 85, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 80, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 75, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 70, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 65, new SortedList<int, int> { { 0, -3 },     { 5, -1 },  { 10, 0 } } },
            { 60, new SortedList<int, int> { { 0, -7 },     { 5, -5 },  { 10, -2 } } },
            { 55, new SortedList<int, int> { { 0, -11 },    { 5, -9 },  { 10, -6 } } },
            { 50, new SortedList<int, int> { { 0, -14 },    { 5, -12 }, { 10, -9 } } },
            { 45, new SortedList<int, int> { { 0, -17 },    { 5, -14 }, { 10, -12 } } },
            { 40, new SortedList<int, int> { { 0, -18 },    { 5, -15 }, { 10, -13 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> Slush3V1CorrNoRev = new()
        {
            { 95, new SortedList<int, int> { { 0, -14 }, { 5, -12 }, { 10, -9 } } },
            { 90, new SortedList<int, int> { { 0, -16 }, { 5, -14 }, { 10, -11 } } },
            { 85, new SortedList<int, int> { { 0, -19 }, { 5, -16 }, { 10, -14 } } },
            { 80, new SortedList<int, int> { { 0, -21 }, { 5, -18 }, { 10, -16 } } },
            { 75, new SortedList<int, int> { { 0, -22 }, { 5, -20 }, { 10, -17 } } },
            { 70, new SortedList<int, int> { { 0, -24 }, { 5, -22 }, { 10, -19 } } },
            { 65, new SortedList<int, int> { { 0, -25 }, { 5, -23 }, { 10, -20 } } },
            { 60, new SortedList<int, int> { { 0, -27 }, { 5, -24 }, { 10, -22 } } },
            { 55, new SortedList<int, int> { { 0, -28 }, { 5, -25 }, { 10, -23 } } },
            { 50, new SortedList<int, int> { { 0, -29 }, { 5, -26 }, { 10, -24 } } },
            { 45, new SortedList<int, int> { { 0, -29 }, { 5, -27 }, { 10, -24 } } },
            { 40, new SortedList<int, int> { { 0, -30 }, { 5, -27 }, { 10, -25 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> Slush6V1CorrNoRev = new()
        {
            { 95, new SortedList<int, int> { { 0, -2 },  { 5, 0 },      { 10, 0 } } },
            { 90, new SortedList<int, int> { { 0, -5 },  { 5, -3 },     { 10, 0 } } },
            { 85, new SortedList<int, int> { { 0, -9 },  { 5, -6 },     { 10, -4 } } },
            { 80, new SortedList<int, int> { { 0, -12 }, { 5, -9 },     { 10, -7 } } },
            { 75, new SortedList<int, int> { { 0, -15 }, { 5, -12 },    { 10, -10 } } },
            { 70, new SortedList<int, int> { { 0, -17 }, { 5, -15 },    { 10, -12 } } },
            { 65, new SortedList<int, int> { { 0, -20 }, { 5, -17 },    { 10, -15 } } },
            { 60, new SortedList<int, int> { { 0, -22 }, { 5, -20 },    { 10, -17 } } },
            { 55, new SortedList<int, int> { { 0, -24 }, { 5, -21 },    { 10, -19 } } },
            { 50, new SortedList<int, int> { { 0, -26 }, { 5, -23 },    { 10, -21 } } },
            { 45, new SortedList<int, int> { { 0, -27 }, { 5, -25 },    { 10, -22 } } },
            { 40, new SortedList<int, int> { { 0, -28 }, { 5, -26 },    { 10, -23 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> Slush13V1CorrNoRev = new()
        {
            { 95, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 90, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 85, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 80, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 75, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 70, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 65, new SortedList<int, int> { { 0, -4 },     { 5, -2 },  { 10, 0 } } },
            { 60, new SortedList<int, int> { { 0, -11 },    { 5, -8 },  { 10, -6 } } },
            { 55, new SortedList<int, int> { { 0, -15 },    { 5, -13 }, { 10, -10 } } },
            { 50, new SortedList<int, int> { { 0, -19 },    { 5, -17 }, { 10, -14 } } },
            { 45, new SortedList<int, int> { { 0, -22 },    { 5, -20 }, { 10, -17 } } },
            { 40, new SortedList<int, int> { { 0, -24 },    { 5, -21 }, { 10, -19 } } }
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
            { 90, new SortedList<int, int> { { 0, -4 },     { 5, -3 },  { 10, -2 } } },
            { 85, new SortedList<int, int> { { 0, -5 },     { 5, -4 },  { 10, -3 } } },
            { 80, new SortedList<int, int> { { 0, -6 },     { 5, -5 },  { 10, -3 } } },
            { 75, new SortedList<int, int> { { 0, -7 },     { 5, -6 },  { 10, -4 } } },
            { 70, new SortedList<int, int> { { 0, -8 },     { 5, -6 },  { 10, -5 } } },
            { 65, new SortedList<int, int> { { 0, -9 },     { 5, -7 },  { 10, -6 } } },
            { 60, new SortedList<int, int> { { 0, -9 },     { 5, -8 },  { 10, -7 } } },
            { 55, new SortedList<int, int> { { 0, -10 },    { 5, -9 },  { 10, -8 } } },
            { 50, new SortedList<int, int> { { 0, -11 },    { 5, -10 }, { 10, -8 } } },
            { 45, new SortedList<int, int> { { 0, -12 },    { 5, -10 }, { 10, -9 } } },
            { 40, new SortedList<int, int> { { 0, -12 },    { 5, -11 }, { 10, -10 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> MediumV1CorrMaxRev = new()
        {
            { 90, new SortedList<int, int> { { 0, -13 }, { 5, -12 }, { 10, -10 } } },
            { 85, new SortedList<int, int> { { 0, -14 }, { 5, -12 }, { 10, -11 } } },
            { 80, new SortedList<int, int> { { 0, -15 }, { 5, -13 }, { 10, -12 } } },
            { 75, new SortedList<int, int> { { 0, -16 }, { 5, -15 }, { 10, -14 } } },
            { 70, new SortedList<int, int> { { 0, -18 }, { 5, -16 }, { 10, -15 } } },
            { 65, new SortedList<int, int> { { 0, -19 }, { 5, -18 }, { 10, -17 } } },
            { 60, new SortedList<int, int> { { 0, -21 }, { 5, -19 }, { 10, -18 } } },
            { 55, new SortedList<int, int> { { 0, -22 }, { 5, -21 }, { 10, -20 } } },
            { 50, new SortedList<int, int> { { 0, -23 }, { 5, -22 }, { 10, -21 } } },
            { 45, new SortedList<int, int> { { 0, -24 }, { 5, -23 }, { 10, -22 } } },
            { 40, new SortedList<int, int> { { 0, -25 }, { 5, -24 }, { 10, -22 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> PoorV1CorrMaxRev = new()
        {
            { 90, new SortedList<int, int> { { 0, -24 }, { 5, -23 }, { 10, -21 } } },
            { 85, new SortedList<int, int> { { 0, -25 }, { 5, -23 }, { 10, -22 } } },
            { 80, new SortedList<int, int> { { 0, -26 }, { 5, -25 }, { 10, -23 } } },
            { 75, new SortedList<int, int> { { 0, -28 }, { 5, -26 }, { 10, -25 } } },
            { 70, new SortedList<int, int> { { 0, -30 }, { 5, -28 }, { 10, -27 } } },
            { 65, new SortedList<int, int> { { 0, -32 }, { 5, -30 }, { 10, -29 } } },
            { 60, new SortedList<int, int> { { 0, -34 }, { 5, -33 }, { 10, -31 } } },
            { 55, new SortedList<int, int> { { 0, -36 }, { 5, -34 }, { 10, -33 } } },
            { 50, new SortedList<int, int> { { 0, -37 }, { 5, -36 }, { 10, -35 } } },
            { 45, new SortedList<int, int> { { 0, -39 }, { 5, -37 }, { 10, -36 } } },
            { 40, new SortedList<int, int> { { 0, -39 }, { 5, -38 }, { 10, -37 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> GoodV1CorrNoRev = new()
        {
            { 95, new SortedList<int, int> { { 0, -4 },     { 5, -2 },  { 10, 0 } } },
            { 90, new SortedList<int, int> { { 0, -5 },     { 5, -3 },  { 10, 0 } } },
            { 85, new SortedList<int, int> { { 0, -6 },     { 5, -4 },  { 10, -1 } } },
            { 80, new SortedList<int, int> { { 0, -7 },     { 5, -5 },  { 10, -2 } } },
            { 75, new SortedList<int, int> { { 0, -8 },     { 5, -6 },  { 10, -3 } } },
            { 70, new SortedList<int, int> { { 0, -9 },     { 5, -7 },  { 10, -4 } } },
            { 65, new SortedList<int, int> { { 0, -11 },    { 5, -8 },  { 10, -6 } } },
            { 60, new SortedList<int, int> { { 0, -12 },    { 5, -9 },  { 10, -7 } } },
            { 55, new SortedList<int, int> { { 0, -13 },    { 5, -10 }, { 10, -8 } } },
            { 50, new SortedList<int, int> { { 0, -14 },    { 5, -11 }, { 10, -9 } } },
            { 45, new SortedList<int, int> { { 0, -15 },    { 5, -12 }, { 10, -10 } } },
            { 40, new SortedList<int, int> { { 0, -15 },    { 5, -13 }, { 10, -10 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> MediumV1CorrNoRev = new()
        {
            { 95, new SortedList<int, int> { { 0, -15 }, { 5, -13 }, { 10, -10 } } },
            { 90, new SortedList<int, int> { { 0, -16 }, { 5, -14 }, { 10, -11 } } },
            { 85, new SortedList<int, int> { { 0, -17 }, { 5, -15 }, { 10, -12 } } },
            { 80, new SortedList<int, int> { { 0, -19 }, { 5, -16 }, { 10, -14 } } },
            { 75, new SortedList<int, int> { { 0, -20 }, { 5, -18 }, { 10, -15 } } },
            { 70, new SortedList<int, int> { { 0, -22 }, { 5, -20 }, { 10, -17 } } },
            { 65, new SortedList<int, int> { { 0, -24 }, { 5, -22 }, { 10, -19 } } },
            { 60, new SortedList<int, int> { { 0, -26 }, { 5, -24 }, { 10, -21 } } },
            { 55, new SortedList<int, int> { { 0, -28 }, { 5, -26 }, { 10, -23 } } },
            { 50, new SortedList<int, int> { { 0, -30 }, { 5, -28 }, { 10, -25 } } },
            { 45, new SortedList<int, int> { { 0, -31 }, { 5, -29 }, { 10, -26 } } },
            { 40, new SortedList<int, int> { { 0, -32 }, { 5, -30 }, { 10, -27 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> PoorV1CorrNoRev = new()
        {
            { 95, new SortedList<int, int> { { 0, -31 }, { 5, -28 }, { 10, -26 } } },
            { 90, new SortedList<int, int> { { 0, -32 }, { 5, -30 }, { 10, -27 } } },
            { 85, new SortedList<int, int> { { 0, -34 }, { 5, -31 }, { 10, -29 } } },
            { 80, new SortedList<int, int> { { 0, -36 }, { 5, -33 }, { 10, -31 } } },
            { 75, new SortedList<int, int> { { 0, -38 }, { 5, -35 }, { 10, -33 } } },
            { 70, new SortedList<int, int> { { 0, -40 }, { 5, -38 }, { 10, -35 } } },
            { 65, new SortedList<int, int> { { 0, -43 }, { 5, -41 }, { 10, -38 } } },
            { 60, new SortedList<int, int> { { 0, -46 }, { 5, -43 }, { 10, -41 } } },
            { 55, new SortedList<int, int> { { 0, -48 }, { 5, -46 }, { 10, -43 } } },
            { 50, new SortedList<int, int> { { 0, -50 }, { 5, -48 }, { 10, -45 } } },
            { 45, new SortedList<int, int> { { 0, -52 }, { 5, -49 }, { 10, -47 } } },
            { 40, new SortedList<int, int> { { 0, -53 }, { 5, -50 }, { 10, -49 } } }
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
            { 90, new int?[] { 172, 172, 174 } },
            { 85, new int?[] { 166, 167, 170 } },
            { 80, new int?[] { 160, 162, 166 } },
            { 75, new int?[] { 155, 156, 161 } },
            { 70, new int?[] { 149, 150, 157 } },
            { 65, new int?[] { 143, 144, 152 } },
            { 60, new int?[] { 137, 138, 147 } },
            { 55, new int?[] { 130, 131, 142 } },
            { 50, new int?[] { 122, 123, 136 } },
            { 45, new int?[] { 115, 116, 130 } },
            { 40, new int?[] { 107, 108, 124 } }
        };

        public static readonly SortedList<int, int?[]> Flaps5VSpeeds = new()
        {
            { 90, new int?[] { null, null, null } },
            { 85, new int?[] { 159, 150, 163 } },
            { 80, new int?[] { 154, 155, 159 } },
            { 75, new int?[] { 149, 150, 155 } },
            { 70, new int?[] { 143, 144, 151 } },
            { 65, new int?[] { 137, 138, 147 } },
            { 60, new int?[] { 131, 132, 142 } },
            { 55, new int?[] { 124, 125, 136 } },
            { 50, new int?[] { 118, 118, 131 } },
            { 45, new int?[] { 110, 111, 125 } },
            { 40, new int?[] { 103, 103, 119 } }
        };

        public static readonly SortedList<int, int?[]> Flaps10VSpeeds = new()
        {
            { 90, new int?[] { null, null, null } },
            { 85, new int?[] { null, null, null } },
            { 80, new int?[] { null, null, null } },
            { 75, new int?[] { 148, 148, 153 } },
            { 70, new int?[] { 142, 143, 149 } },
            { 65, new int?[] { 136, 137, 145 } },
            { 60, new int?[] { 130, 131, 140 } },
            { 55, new int?[] { 123, 124, 135 } },
            { 50, new int?[] { 116, 117, 129 } },
            { 45, new int?[] { 109, 110, 124 } },
            { 40, new int?[] { 102, 102, 118 } }
        };

        public static readonly SortedList<int, int?[]> Flaps15VSpeeds = new()
        {
            { 90, new int?[] { null, null, null } },
            { 85, new int?[] { null, null, null } },
            { 80, new int?[] { null, null, null } },
            { 75, new int?[] { 145, 145, 150 } },
            { 70, new int?[] { 139, 140, 146 } },
            { 65, new int?[] { 133, 134, 142 } },
            { 60, new int?[] { 127, 128, 137 } },
            { 55, new int?[] { 121, 121, 132 } },
            { 50, new int?[] { 114, 115, 127 } },
            { 45, new int?[] { 107, 107, 121 } },
            { 40, new int?[] {  99, 100, 116 } }
        };

        public static readonly SortedList<int, int?[]> Flaps25VSpeeds = new()
        {
            { 90, new int?[] { null, null, null } },
            { 85, new int?[] { null, null, null } },
            { 80, new int?[] { null, null, null } },
            { 75, new int?[] { 142, 142, 148 } },
            { 70, new int?[] { 137, 137, 144 } },
            { 65, new int?[] { 131, 131, 139 } },
            { 60, new int?[] { 125, 125, 135 } },
            { 55, new int?[] { 118, 119, 130 } },
            { 50, new int?[] { 112, 112, 125 } },
            { 45, new int?[] { 105, 105, 119 } },
            { 40, new int?[] {  97,  98, 114 } }
        };

        public static readonly SortedList<int, SortedList<int, int?>> DensAltCorrV1 = new()
        {
            { 70,   new SortedList<int, int?> { { -2, 5 }, { 0, 6 }, { 2, null },   { 4, null },    { 6, null },    { 8, null },    { 10, null } } },
            { 60,   new SortedList<int, int?> { { -2, 4 }, { 0, 5 }, { 2, 6 },      { 4, 6 },       { 6, null },    { 8, null },    { 10, null } } },
            { 50,   new SortedList<int, int?> { { -2, 2 }, { 0, 3 }, { 2, 5 },      { 4, 5 },       { 6, 6 },       { 8, 7 },       { 10, 8 } } },
            { 40,   new SortedList<int, int?> { { -2, 1 }, { 0, 2 }, { 2, 4 },      { 4, 4 },       { 6, 5 },       { 8, 6 },       { 10, 7 } } },
            { 30,   new SortedList<int, int?> { { -2, 0 }, { 0, 0 }, { 2, 3 },      { 4, 3 },       { 6, 4 },       { 8, 5 },       { 10, 6 } } },
            { 20,   new SortedList<int, int?> { { -2, 0 }, { 0, 0 }, { 2, 1 },      { 4, 1 },       { 6, 2 },       { 8, 4 },       { 10, 5 } } },
            { -60,  new SortedList<int, int?> { { -2, 0 }, { 0, 0 }, { 2, 1 },      { 4, 1 },       { 6, 2 },       { 8, 3 },       { 10, 4 } } }
        };

        public static readonly SortedList<int, SortedList<int, int?>> DensAltCorrVr = new()
        {
            { 70,   new SortedList<int, int?> { { -2, 5 }, { 0, 5 }, { 2, null },   { 4, null },    { 6, null },    { 8, null },    { 10, null } } },
            { 60,   new SortedList<int, int?> { { -2, 3 }, { 0, 4 }, { 2, 5 },      { 4, 6 },       { 6, null },    { 8, null },    { 10, null } } },
            { 50,   new SortedList<int, int?> { { -2, 2 }, { 0, 3 }, { 2, 4 },      { 4, 5 },       { 6, 6 },       { 8, 7 },       { 10, 8 } } },
            { 40,   new SortedList<int, int?> { { -2, 1 }, { 0, 2 }, { 2, 3 },      { 4, 4 },       { 6, 5 },       { 8, 6 },       { 10, 7 } } },
            { 30,   new SortedList<int, int?> { { -2, 0 }, { 0, 0 }, { 2, 1 },      { 4, 2 },       { 6, 4 },       { 8, 5 },       { 10, 6 } } },
            { 20,   new SortedList<int, int?> { { -2, 0 }, { 0, 0 }, { 2, 1 },      { 4, 1 },       { 6, 2 },       { 8, 4 },       { 10, 5 } } },
            { -60,  new SortedList<int, int?> { { -2, 0 }, { 0, 0 }, { 2, 1 },      { 4, 1 },       { 6, 2 },       { 8, 3 },       { 10, 4 } } }
        };

        public static readonly SortedList<int, SortedList<int, int?>> DensAltCorrV2 = new()
        {
            { 70,   new SortedList<int, int?> { { -2, -3 },   { 0, -4 },  { 2, null },    { 4, null },    { 6, null },    { 8, null },    { 10, null } } },
            { 60,   new SortedList<int, int?> { { -2, -2 },   { 0, -3 },  { 2, -3 },      { 4, -4 },      { 6, null },    { 8, null },    { 10, null } } },
            { 50,   new SortedList<int, int?> { { -2, -2 },   { 0, -2 },  { 2, -3 },      { 4, -3 },      { 6, -4 },      { 8, -4 },      { 10, -5 } } },
            { 40,   new SortedList<int, int?> { { -2, -1 },   { 0, -1 },  { 2, -2 },      { 4, -2 },      { 6, -3 },      { 8, -4 },      { 10, -4 } } },
            { 30,   new SortedList<int, int?> { { -2,  0 },   { 0,  0 },  { 2, -1 },      { 4, -1 },      { 6, -2 },      { 8, -3 },      { 10, -4 } } },
            { 20,   new SortedList<int, int?> { { -2,  0 },   { 0,  0 },  { 2,  0 },      { 4, -1 },      { 6, -1 },      { 8, -2 },      { 10, -3 } } },
            { -60,  new SortedList<int, int?> { { -2,  0 },   { 0,  0 },  { 2,  0 },      { 4, -1 },      { 6, -1 },      { 8, -1 },      { 10, -2 } } }
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
            { 90, new SortedList<int, int> { { -2, -3 },    { -1, -2 }, { 0, 0 }, { 1, 1 }, { 2, 1 } } },
            { 80, new SortedList<int, int> { { -2, -3 },    { -1, -1 }, { 0, 0 }, { 1, 1 }, { 2, 1 } } },
            { 70, new SortedList<int, int> { { -2, -2 },    { -1, -1 }, { 0, 0 }, { 1, 1 }, { 2, 1 } } },
            { 60, new SortedList<int, int> { { -2, -1 },    { -1, -1 }, { 0, 0 }, { 1, 1 }, { 2, 1 } } },
            { 50, new SortedList<int, int> { { -2, -1 },    { -1, 0 },  { 0, 0 }, { 1, 1 }, { 2, 1 } } },
            { 40, new SortedList<int, int> { { -2, 0 },     { -1, 0 },  { 0, 0 }, { 1, 0 }, { 2, 1 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> WindCorr = new()           
        {
            { 90, new SortedList<int, int> { { -15, -1 }, { -10, -1 }, { -5, 0 },  { 0, 0 }, { 10, 0 }, { 20, 1 }, { 30, 0 }, { 40, 1 } } },
            { 80, new SortedList<int, int> { { -15, -1 }, { -10, -1 }, { -5, 0 },  { 0, 0 }, { 10, 0 }, { 20, 1 }, { 30, 1 }, { 40, 1 } } },
            { 70, new SortedList<int, int> { { -15, -1 }, { -10, -1 }, { -5, 0 },  { 0, 0 }, { 10, 0 }, { 20, 1 }, { 30, 1 }, { 40, 1 } } },
            { 60, new SortedList<int, int> { { -15, -1 }, { -10, -1 }, { -5, 0 },  { 0, 0 }, { 10, 0 }, { 20, 1 }, { 30, 1 }, { 40, 1 } } },
            { 50, new SortedList<int, int> { { -15, -1 }, { -10, -1 }, { -5, 0 },  { 0, 0 }, { 10, 0 }, { 20, 1 }, { 30, 1 }, { 40, 1 } } },
            { 40, new SortedList<int, int> { { -15, -2 }, { -10, -1 }, { -5, 0 },  { 0, 0 }, { 10, 0 }, { 20, 0 }, { 30, 1 }, { 40, 1 } } }
        };

        public static readonly SortedList<int, SortedList<int, int?>> Vmcg = new()           
        {
            { 70,   new SortedList<int, int?> { { -2, 90 },  { 0, 88 },  { 2, null }, { 4, null }, { 6, null }, { 8, null }, { 10, null } } },
            { 60,   new SortedList<int, int?> { { -2, 90 },  { 0, 88 },  { 2, 87 },   { 4, 85 },   { 6, null }, { 8, null }, { 10, null } } },
            { 50,   new SortedList<int, int?> { { -2, 92 },  { 0, 90 },  { 2, 87 },   { 4, 85 },   { 6, 83 },   { 8, 81 },   { 10, 79 } } },
            { 40,   new SortedList<int, int?> { { -2, 97 },  { 0, 95 },  { 2, 91 },   { 4, 88 },   { 6, 84 },   { 8, 81 },   { 10, 79 } } },
            { 30,   new SortedList<int, int?> { { -2, 100 }, { 0, 99 },  { 2, 95 },   { 4, 92 },   { 6, 88 },   { 8, 85 },   { 10, 81 } } },
            { 20,   new SortedList<int, int?> { { -2, 100 }, { 0, 99 },  { 2, 97 },   { 4, 95 },   { 6, 92 },   { 8, 88 },   { 10, 85 } } },
            { -60,  new SortedList<int, int?> { { -2, 101 }, { 0, 101 }, { 2, 98 },   { 4, 96 },   { 6, 94 },   { 8, 91 },   { 10, 89 } } },
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
