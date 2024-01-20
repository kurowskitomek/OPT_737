using OPTCore.PerformanceCalculation.Models;

namespace OPTCore.PerformanceCalculation.Data
{
    public class TOPerf22K
    {
        public static readonly SortedList<int, SortedList<int, int>> Slush3V1CorrMaxRev = new()
        {
            { 90, new SortedList<int, int> { { 0, -12 }, { 5, -10 }, { 10, -7 } } },
            { 85, new SortedList<int, int> { { 0, -13 }, { 5, -10 }, { 10, -8 } } },
            { 80, new SortedList<int, int> { { 0, -14 }, { 5, -11 }, { 10, -9 } } },
            { 75, new SortedList<int, int> { { 0, -15 }, { 5, -12 }, { 10, -10 } } },
            { 70, new SortedList<int, int> { { 0, -16 }, { 5, -13 }, { 10, -11 } } },
            { 65, new SortedList<int, int> { { 0, -17 }, { 5, -15 }, { 10, -12 } } },
            { 60, new SortedList<int, int> { { 0, -19 }, { 5, -16 }, { 10, -14 } } },
            { 55, new SortedList<int, int> { { 0, -20 }, { 5, -18 }, { 10, -15 } } },
            { 50, new SortedList<int, int> { { 0, -21 }, { 5, -18 }, { 10, -16 } } },
            { 45, new SortedList<int, int> { { 0, -21 }, { 5, -19 }, { 10, -16 } } },
            { 40, new SortedList<int, int> { { 0, -21 }, { 5, -18 }, { 10, -16 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> Slush6V1CorrMaxRev = new()
        {
            { 90, new SortedList<int, int> { { 0, -7 },     { 5, -4 },  { 10, -2 } } },
            { 85, new SortedList<int, int> { { 0, -7 },     { 5, -4 },  { 10, -2 } } },
            { 80, new SortedList<int, int> { { 0, -7 },     { 5, -5 },  { 10, -2 } } },
            { 75, new SortedList<int, int> { { 0, -8 },     { 5, -6 },  { 10, -3 } } },
            { 70, new SortedList<int, int> { { 0, -10 },    { 5, -7 },  { 10, -5 } } },
            { 65, new SortedList<int, int> { { 0, -12 },    { 5, -9 },  { 10, -7 } } },
            { 60, new SortedList<int, int> { { 0, -14 },    { 5, -12 }, { 10, -9 } } },
            { 55, new SortedList<int, int> { { 0, -17 },    { 5, -14 }, { 10, -12 } } },
            { 50, new SortedList<int, int> { { 0, -18 },    { 5, -16 }, { 10, -13 } } },
            { 45, new SortedList<int, int> { { 0, -19 },    { 5, -17 }, { 10, -14 } } },
            { 40, new SortedList<int, int> { { 0, -19 },    { 5, -17 }, { 10, -14 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> Slush13V1CorrMaxRev = new()
        {
            { 90, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 85, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 80, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 75, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 70, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 65, new SortedList<int, int> { { 0, -1 },     { 5, 0 },   { 10, 0 } } },
            { 60, new SortedList<int, int> { { 0, -5 },     { 5, -2 },  { 10, 0 } } },
            { 55, new SortedList<int, int> { { 0, -9 },     { 5, -6 },  { 10, -4 } } },
            { 50, new SortedList<int, int> { { 0, -12 },    { 5, -10 }, { 10, -7 } } },
            { 45, new SortedList<int, int> { { 0, -14 },    { 5, -12 }, { 10, -9 } } },
            { 40, new SortedList<int, int> { { 0, -16 },    { 5, -14 }, { 10, -11 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> Slush3V1CorrNoRev = new()
        {
            { 95, new SortedList<int, int> { { 0,  -9 }, { 5,  -7 }, { 10, -4 } } },
            { 90, new SortedList<int, int> { { 0, -12 }, { 5, -10 }, { 10, -7 } } },
            { 85, new SortedList<int, int> { { 0, -15 }, { 5, -12 }, { 10, -10 } } },
            { 80, new SortedList<int, int> { { 0, -17 }, { 5, -15 }, { 10, -12 } } },
            { 75, new SortedList<int, int> { { 0, -19 }, { 5, -17 }, { 10, -14 } } },
            { 70, new SortedList<int, int> { { 0, -21 }, { 5, -19 }, { 10, -16 } } },
            { 65, new SortedList<int, int> { { 0, -23 }, { 5, -21 }, { 10, -18 } } },
            { 60, new SortedList<int, int> { { 0, -25 }, { 5, -22 }, { 10, -20 } } },
            { 55, new SortedList<int, int> { { 0, -26 }, { 5, -23 }, { 10, -21 } } },
            { 50, new SortedList<int, int> { { 0, -27 }, { 5, -24 }, { 10, -22 } } },
            { 45, new SortedList<int, int> { { 0, -28 }, { 5, -25 }, { 10, -23 } } },
            { 40, new SortedList<int, int> { { 0, -28 }, { 5, -26 }, { 10, -23 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> Slush6V1CorrNoRev = new()
        {
            { 95, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 90, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 85, new SortedList<int, int> { { 0, -3 },     { 5, -1 },  { 10, 0 } } },
            { 80, new SortedList<int, int> { { 0, -7 },     { 5, -5 },  { 10, -2 } } },
            { 75, new SortedList<int, int> { { 0, -11 },    { 5, -8 },  { 10, -6 } } },
            { 70, new SortedList<int, int> { { 0, -14 },    { 5, -11 }, { 10, -9 } } },
            { 65, new SortedList<int, int> { { 0, -17 },    { 5, -14 }, { 10, -12 } } },
            { 60, new SortedList<int, int> { { 0, -19 },    { 5, -17 }, { 10, -14 } } },
            { 55, new SortedList<int, int> { { 0, -22 },    { 5, -19 }, { 10, -17 } } },
            { 50, new SortedList<int, int> { { 0, -24 },    { 5, -21 }, { 10, -19 } } },
            { 45, new SortedList<int, int> { { 0, -25 },    { 5, -23 }, { 10, -20 } } },
            { 40, new SortedList<int, int> { { 0, -27 },    { 5, -24 }, { 10, -22 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> Slush13V1CorrNoRev = new()
        {
            { 95, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 90, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 85, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 80, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 75, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 70, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 65, new SortedList<int, int> { { 0, 0 },      { 5, 0 },   { 10, 0 } } },
            { 60, new SortedList<int, int> { { 0, -6 },     { 5, -4 },  { 10, -1 } } },
            { 55, new SortedList<int, int> { { 0, -12 },    { 5, -10 }, { 10, -7 } } },
            { 50, new SortedList<int, int> { { 0, -16 },    { 5, -14 }, { 10, -11 } } },
            { 45, new SortedList<int, int> { { 0, -20 },    { 5, -17 }, { 10, -15 } } },
            { 40, new SortedList<int, int> { { 0, -22 },    { 5, -19 }, { 10, -17 } } }
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
            { 90, new SortedList<int, int> { { 0, -5 },     { 5, -3 },  { 10, -2 } } },
            { 85, new SortedList<int, int> { { 0, -5 },     { 5, -4 },  { 10, -2 } } },
            { 80, new SortedList<int, int> { { 0, -5 },     { 5, -4 },  { 10, -3 } } },
            { 75, new SortedList<int, int> { { 0, -6 },     { 5, -5 },  { 10, -4 } } },
            { 70, new SortedList<int, int> { { 0, -7 },     { 5, -6 },  { 10, -5 } } },
            { 65, new SortedList<int, int> { { 0, -8 },     { 5, -7 },  { 10, -5 } } },
            { 60, new SortedList<int, int> { { 0, -9 },     { 5, -8 },  { 10, -6 } } },
            { 55, new SortedList<int, int> { { 0, -10 },    { 5, -8 },  { 10, -7 } } },
            { 50, new SortedList<int, int> { { 0, -10 },    { 5, -9 },  { 10, -8 } } },
            { 45, new SortedList<int, int> { { 0, -11 },    { 5, -10 }, { 10, -8 } } },
            { 40, new SortedList<int, int> { { 0, -11 },    { 5, -10 }, { 10, -8 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> MediumV1CorrMaxRev = new()
        {
            { 90, new SortedList<int, int> { { 0, -14 }, { 5, -13 }, { 10, -11 } } },
            { 85, new SortedList<int, int> { { 0, -13 }, { 5, -12 }, { 10, -11 } } },
            { 80, new SortedList<int, int> { { 0, -14 }, { 5, -12 }, { 10, -11 } } },
            { 75, new SortedList<int, int> { { 0, -15 }, { 5, -13 }, { 10, -12 } } },
            { 70, new SortedList<int, int> { { 0, -16 }, { 5, -15 }, { 10, -13 } } },
            { 65, new SortedList<int, int> { { 0, -17 }, { 5, -16 }, { 10, -15 } } },
            { 60, new SortedList<int, int> { { 0, -19 }, { 5, -18 }, { 10, -17 } } },
            { 55, new SortedList<int, int> { { 0, -21 }, { 5, -19 }, { 10, -18 } } },
            { 50, new SortedList<int, int> { { 0, -22 }, { 5, -21 }, { 10, -19 } } },
            { 45, new SortedList<int, int> { { 0, -23 }, { 5, -22 }, { 10, -20 } } },
            { 40, new SortedList<int, int> { { 0, -23 }, { 5, -22 }, { 10, -21 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> PoorV1CorrMaxRev = new()
        {
            { 90, new SortedList<int, int> { { 0, -24 }, { 5, -23 }, { 10, -22 } } },
            { 85, new SortedList<int, int> { { 0, -24 }, { 5, -22 }, { 10, -21 } } },
            { 80, new SortedList<int, int> { { 0, -24 }, { 5, -23 }, { 10, -21 } } },
            { 75, new SortedList<int, int> { { 0, -25 }, { 5, -24 }, { 10, -23 } } },
            { 70, new SortedList<int, int> { { 0, -27 }, { 5, -26 }, { 10, -24 } } },
            { 65, new SortedList<int, int> { { 0, -29 }, { 5, -28 }, { 10, -26 } } },
            { 60, new SortedList<int, int> { { 0, -31 }, { 5, -30 }, { 10, -29 } } },
            { 55, new SortedList<int, int> { { 0, -33 }, { 5, -32 }, { 10, -31 } } },
            { 50, new SortedList<int, int> { { 0, -35 }, { 5, -34 }, { 10, -33 } } },
            { 45, new SortedList<int, int> { { 0, -37 }, { 5, -35 }, { 10, -34 } } },
            { 40, new SortedList<int, int> { { 0, -37 }, { 5, -36 }, { 10, -35 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> GoodV1CorrNoRev = new()
        {
            { 95, new SortedList<int, int> { { 0, -5 },     { 5, -3 },  { 10, 0 } } },
            { 90, new SortedList<int, int> { { 0, -6 },     { 5, -3 },  { 10, -1 } } },
            { 85, new SortedList<int, int> { { 0, -6 },     { 5, -4 },  { 10, -1 } } },
            { 80, new SortedList<int, int> { { 0, -7 },     { 5, -4 },  { 10, -2 } } },
            { 75, new SortedList<int, int> { { 0, -8 },     { 5, -5 },  { 10, -3 } } },
            { 70, new SortedList<int, int> { { 0, -9 },     { 5, -6 },  { 10, -4 } } },
            { 65, new SortedList<int, int> { { 0, -10 },    { 5, -7 },  { 10, -5 } } },
            { 60, new SortedList<int, int> { { 0, -11 },    { 5, -8 },  { 10, -6 } } },
            { 55, new SortedList<int, int> { { 0, -12 },    { 5, -9 },  { 10, -7 } } },
            { 50, new SortedList<int, int> { { 0, -13 },    { 5, -10 }, { 10, -8 } } },
            { 45, new SortedList<int, int> { { 0, -13 },    { 5, -11 }, { 10, -8 } } },
            { 40, new SortedList<int, int> { { 0, -14 },    { 5, -11 }, { 10, -9 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> MediumV1CorrNoRev = new()
        {
            { 95, new SortedList<int, int> { { 0, -17 }, { 5, -14 }, { 10, -12 } } },
            { 90, new SortedList<int, int> { { 0, -17 }, { 5, -14 }, { 10, -12 } } },
            { 85, new SortedList<int, int> { { 0, -17 }, { 5, -14 }, { 10, -12 } } },
            { 80, new SortedList<int, int> { { 0, -17 }, { 5, -15 }, { 10, -12 } } },
            { 75, new SortedList<int, int> { { 0, -18 }, { 5, -16 }, { 10, -13 } } },
            { 70, new SortedList<int, int> { { 0, -20 }, { 5, -18 }, { 10, -15 } } },
            { 65, new SortedList<int, int> { { 0, -22 }, { 5, -20 }, { 10, -17 } } },
            { 60, new SortedList<int, int> { { 0, -24 }, { 5, -22 }, { 10, -19 } } },
            { 55, new SortedList<int, int> { { 0, -26 }, { 5, -24 }, { 10, -21 } } },
            { 50, new SortedList<int, int> { { 0, -28 }, { 5, -26 }, { 10, -23 } } },
            { 45, new SortedList<int, int> { { 0, -30 }, { 5, -27 }, { 10, -25 } } },
            { 40, new SortedList<int, int> { { 0, -31 }, { 5, -28 }, { 10, -26 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> PoorV1CorrNoRev = new()
        {
            { 95, new SortedList<int, int> { { 0, -32 }, { 5, -30 }, { 10, -27 } } },
            { 90, new SortedList<int, int> { { 0, -32 }, { 5, -30 }, { 10, -27 } } },
            { 85, new SortedList<int, int> { { 0, -32 }, { 5, -30 }, { 10, -27 } } },
            { 80, new SortedList<int, int> { { 0, -33 }, { 5, -30 }, { 10, -28 } } },
            { 75, new SortedList<int, int> { { 0, -35 }, { 5, -32 }, { 10, -30 } } },
            { 70, new SortedList<int, int> { { 0, -37 }, { 5, -34 }, { 10, -32 } } },
            { 65, new SortedList<int, int> { { 0, -40 }, { 5, -37 }, { 10, -35 } } },
            { 60, new SortedList<int, int> { { 0, -43 }, { 5, -40 }, { 10, -38 } } },
            { 55, new SortedList<int, int> { { 0, -45 }, { 5, -43 }, { 10, -40 } } },
            { 50, new SortedList<int, int> { { 0, -48 }, { 5, -45 }, { 10, -43 } } },
            { 45, new SortedList<int, int> { { 0, -49 }, { 5, -47 }, { 10, -44 } } },
            { 40, new SortedList<int, int> { { 0, -50 }, { 5, -48 }, { 10, -45 } } }
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
            { 80, new int?[] { 162, 163, 165 } },
            { 76, new int?[] { 158, 158, 162 } },
            { 72, new int?[] { 153, 154, 158 } },
            { 68, new int?[] { 148, 149, 155 } },
            { 64, new int?[] { 143, 144, 151 } },
            { 60, new int?[] { 138, 139, 147 } },
            { 56, new int?[] { 132, 133, 142 } },
            { 52, new int?[] { 127, 127, 138 } },
            { 48, new int?[] { 121, 121, 133 } },
            { 44, new int?[] { 115, 115, 128 } },
            { 40, new int?[] { 108, 108, 123 } }
        };

        public static readonly SortedList<int, int?[]> Flaps5VSpeeds = new()
        {
            { 80, new int?[] { 156, 156, 159 } },
            { 76, new int?[] { 152, 152, 156 } },
            { 72, new int?[] { 147, 147, 152 } },
            { 68, new int?[] { 142, 143, 149 } },
            { 64, new int?[] { 138, 138, 145 } },
            { 60, new int?[] { 132, 133, 141 } },
            { 56, new int?[] { 127, 128, 137 } },
            { 52, new int?[] { 122, 122, 132 } },
            { 48, new int?[] { 116, 116, 128 } },
            { 44, new int?[] { 110, 111, 123 } },
            { 40, new int?[] { 104, 104, 118 } }
        };

        public static readonly SortedList<int, int?[]> Flaps10VSpeeds = new()
        {
            { 80, new int?[] { null, null, null } },
            { 76, new int?[] { null, null, null } },
            { 72, new int?[] { 146, 146, 150 } },
            { 68, new int?[] { 141, 141, 147 } },
            { 64, new int?[] { 136, 137, 143 } },
            { 60, new int?[] { 131, 132, 139 } },
            { 56, new int?[] { 126, 126, 135 } },
            { 52, new int?[] { 121, 121, 131 } },
            { 48, new int?[] { 115, 115, 126 } },
            { 44, new int?[] { 109, 109, 122 } },
            { 40, new int?[] { 103, 103, 117 } }
        };

        public static readonly SortedList<int, int?[]> Flaps15VSpeeds = new()
        {
            { 80, new int?[] { null, null, null } },
            { 76, new int?[] { null, null, null } },
            { 72, new int?[] { 142, 142, 147 } },
            { 68, new int?[] { 138, 138, 144 } },
            { 64, new int?[] { 134, 134, 140 } },
            { 60, new int?[] { 128, 129, 136 } },
            { 56, new int?[] { 123, 124, 132 } },
            { 52, new int?[] { 118, 118, 128 } },
            { 48, new int?[] { 112, 113, 124 } },
            { 44, new int?[] { 107, 107, 119 } },
            { 40, new int?[] { 100, 101, 115 } }
        };

        public static readonly SortedList<int, int?[]> Flaps25VSpeeds = new()
        {
            { 80, new int?[] { null, null, null } },
            { 76, new int?[] { null, null, null } },
            { 72, new int?[] { null, null, null } },
            { 68, new int?[] { null, null, null } },
            { 64, new int?[] { 131, 131, 138 } },
            { 60, new int?[] { 126, 126, 134 } },
            { 56, new int?[] { 121, 121, 130 } },
            { 52, new int?[] { 116, 116, 126 } },
            { 48, new int?[] { 110, 110, 122 } },
            { 44, new int?[] { 105, 105, 117 } },
            { 40, new int?[] {  98,  99, 113 } }
        };
     
        public static readonly SortedList<int, SortedList<int, int?>> DensAltCorrV1 = new()
        {
            { 70,   new SortedList<int, int?> { { -2, 5 }, { 0, 5 }, { 2, null },   { 4, null },    { 6, null },    { 8, null },    { 10, null } } },
            { 60,   new SortedList<int, int?> { { -2, 4 }, { 0, 4 }, { 2, 5 },      { 4, 6 },       { 6, null },    { 8, null },    { 10, null } } },
            { 50,   new SortedList<int, int?> { { -2, 2 }, { 0, 3 }, { 2, 4 },      { 4, 5 },       { 6, 6 },       { 8, 7 },       { 10, 8 } } },
            { 40,   new SortedList<int, int?> { { -2, 1 }, { 0, 2 }, { 2, 3 },      { 4, 4 },       { 6, 5 },       { 8, 6 },       { 10, 7 } } },
            { 30,   new SortedList<int, int?> { { -2, 0 }, { 0, 0 }, { 2, 1 },      { 4, 2 },       { 6, 3 },       { 8, 5 },       { 10, 6 } } },
            { 20,   new SortedList<int, int?> { { -2, 0 }, { 0, 0 }, { 2, 0 },      { 4, 1 },       { 6, 2 },       { 8, 3 },       { 10, 5 } } },
            { -60,  new SortedList<int, int?> { { -2, 0 }, { 0, 0 }, { 2, 0 },      { 4, 1 },       { 6, 2 },       { 8, 2 },       { 10, 3 } } }
        };

        public static readonly SortedList<int, SortedList<int, int?>> DensAltCorrVr = new()
        {
            { 70,   new SortedList<int, int?> { { -2, 5 }, { 0, 5 }, { 2, null },   { 4, null },    { 6, null },    { 8, null },    { 10, null } } },
            { 60,   new SortedList<int, int?> { { -2, 4 }, { 0, 4 }, { 2, 5 },      { 4, 6 },       { 6, null },    { 8, null },    { 10, null } } },
            { 50,   new SortedList<int, int?> { { -2, 2 }, { 0, 3 }, { 2, 4 },      { 4, 5 },       { 6, 6 },       { 8, 7 },       { 10, 8 } } },
            { 40,   new SortedList<int, int?> { { -2, 1 }, { 0, 2 }, { 2, 3 },      { 4, 4 },       { 6, 5 },       { 8, 6 },       { 10, 7 } } },
            { 30,   new SortedList<int, int?> { { -2, 0 }, { 0, 0 }, { 2, 1 },      { 4, 2 },       { 6, 4 },       { 8, 5 },       { 10, 6 } } },
            { 20,   new SortedList<int, int?> { { -2, 0 }, { 0, 0 }, { 2, 1 },      { 4, 1 },       { 6, 2 },       { 8, 3 },       { 10, 5 } } },
            { -60,  new SortedList<int, int?> { { -2, 0 }, { 0, 0 }, { 2, 1 },      { 4, 1 },       { 6, 2 },       { 8, 3 },       { 10, 3 } } }
        };

        public static readonly SortedList<int, SortedList<int, int?>> DensAltCorrV2 = new()
        {
            { 70,   new SortedList<int, int?> { { -2, -3 },   { 0, -3 },  { 2, null },    { 4, null },    { 6, null },    { 8, null },    { 10, null } } },
            { 60,   new SortedList<int, int?> { { -2, -2 },   { 0, -3 },  { 2, -3 },      { 4, -4 },      { 6, null },    { 8, null },    { 10, null } } },
            { 50,   new SortedList<int, int?> { { -2, -1 },   { 0, -2 },  { 2, -2 },      { 4, -3 },      { 6, -3 },      { 8, -4 },      { 10, -5 } } },
            { 40,   new SortedList<int, int?> { { -2, -1 },   { 0, -1 },  { 2, -1 },      { 4, -2 },      { 6, -3 },      { 8, -3 },      { 10, -4 } } },
            { 30,   new SortedList<int, int?> { { -2,  0 },   { 0,  0 },  { 2, -1 },      { 4, -1 },      { 6, -2 },      { 8, -3 },      { 10, -3 } } },
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
            { 80, new SortedList<int, int> { { -2, -3 },    { -1, -2 }, { 0, 0 }, { 1, 1 }, { 2, 1 } } },
            { 76, new SortedList<int, int> { { -2, -3 },    { -1, -1 }, { 0, 0 }, { 1, 1 }, { 2, 1 } } },
            { 72, new SortedList<int, int> { { -2, -2 },    { -1, -1 }, { 0, 0 }, { 1, 1 }, { 2, 1 } } },
            { 68, new SortedList<int, int> { { -2, -2 },    { -1, -1 }, { 0, 0 }, { 1, 1 }, { 2, 1 } } },
            { 64, new SortedList<int, int> { { -2, -2 },    { -1, -1 }, { 0, 0 }, { 1, 1 }, { 2, 1 } } },
            { 60, new SortedList<int, int> { { -2, -1 },    { -1, -1 }, { 0, 0 }, { 1, 1 }, { 2, 1 } } },
            { 56, new SortedList<int, int> { { -2, -1 },    { -1, 0 },  { 0, 0 }, { 1, 1 }, { 2, 1 } } },
            { 52, new SortedList<int, int> { { -2, -1 },    { -1, 0 },  { 0, 0 }, { 1, 1 }, { 2, 1 } } },
            { 48, new SortedList<int, int> { { -2, -1 },    { -1, 0 },  { 0, 0 }, { 1, 0 }, { 2, 1 } } },
            { 44, new SortedList<int, int> { { -2, 0 },     { -1, 0 },  { 0, 0 }, { 1, 0 }, { 2, 1 } } },
            { 40, new SortedList<int, int> { { -2, 0 },     { -1, 0 },  { 0, 0 }, { 1, 0 }, { 2, 1 } } }
        };

        public static readonly SortedList<int, SortedList<int, int>> WindCorr = new()           
        {
            { 80, new SortedList<int, int> { { -15, -1 }, { -10, -1 }, { -5, 0 },  { 0, 0 }, { 10, 0 }, { 20, 1 }, { 30, 1 }, { 40, 1 } } },
            { 76, new SortedList<int, int> { { -15, -1 }, { -10, -1 }, { -5, 0 },  { 0, 0 }, { 10, 0 }, { 20, 1 }, { 30, 1 }, { 40, 1 } } },
            { 72, new SortedList<int, int> { { -15, -1 }, { -10, -1 }, { -5, 0 },  { 0, 0 }, { 10, 0 }, { 20, 1 }, { 30, 1 }, { 40, 1 } } },
            { 68, new SortedList<int, int> { { -15, -1 }, { -10, -1 }, { -5, 0 },  { 0, 0 }, { 10, 0 }, { 20, 1 }, { 30, 1 }, { 40, 1 } } },
            { 64, new SortedList<int, int> { { -15, -1 }, { -10, -1 }, { -5, 0 },  { 0, 0 }, { 10, 0 }, { 20, 1 }, { 30, 1 }, { 40, 1 } } },
            { 60, new SortedList<int, int> { { -15, -2 }, { -10, -1 }, { -5, 0 },  { 0, 0 }, { 10, 0 }, { 20, 1 }, { 30, 1 }, { 40, 1 } } },
            { 56, new SortedList<int, int> { { -15, -2 }, { -10, -1 }, { -5, 0 },  { 0, 0 }, { 10, 0 }, { 20, 1 }, { 30, 1 }, { 40, 1 } } },
            { 52, new SortedList<int, int> { { -15, -2 }, { -10, -1 }, { -5, 0 },  { 0, 0 }, { 10, 0 }, { 20, 1 }, { 30, 1 }, { 40, 1 } } },
            { 48, new SortedList<int, int> { { -15, -2 }, { -10, -1 }, { -5, 0 },  { 0, 0 }, { 10, 0 }, { 20, 1 }, { 30, 1 }, { 40, 1 } } },
            { 44, new SortedList<int, int> { { -15, -2 }, { -10, -1 }, { -5, 0 },  { 0, 0 }, { 10, 0 }, { 20, 1 }, { 30, 1 }, { 40, 1 } } },
            { 40, new SortedList<int, int> { { -15, -2 }, { -10, -1 }, { -5, 0 },  { 0, 0 }, { 10, 0 }, { 20, 1 }, { 30, 1 }, { 40, 1 } } }                      
        };

        public static readonly SortedList<int, SortedList<int, int?>> Vmcg = new()           
        {
            { 70,   new SortedList<int, int?> { { -2, 87 }, { 0, 85 }, { 2, null }, { 4, null }, { 6, null }, { 8, null }, { 10, null } } },
            { 60,   new SortedList<int, int?> { { -2, 87 }, { 0, 85 }, { 2, 84 },   { 4, 83 },   { 6, null }, { 8, null }, { 10, null } } },
            { 50,   new SortedList<int, int?> { { -2, 89 }, { 0, 87 }, { 2, 84 },   { 4, 83 },   { 6, 81 },   { 8, 79 },   { 10, 77 } } },
            { 40,   new SortedList<int, int?> { { -2, 94 }, { 0, 91 }, { 2, 88 },   { 4, 85 },   { 6, 82 },   { 8, 79 },   { 10, 77 } } },
            { 30,   new SortedList<int, int?> { { -2, 96 }, { 0, 96 }, { 2, 93 },   { 4, 89 },   { 6, 86 },   { 8, 82 },   { 10, 79 } } },
            { 20,   new SortedList<int, int?> { { -2, 97 }, { 0, 96 }, { 2, 94 },   { 4, 93 },   { 6, 90 },   { 8, 86 },   { 10, 82 } } },
            { -60,  new SortedList<int, int?> { { -2, 98 }, { 0, 98 }, { 2, 96 },   { 4, 94 },   { 6, 91 },   { 8, 89 },   { 10, 87 } } },
        };

        public static readonly SortedList<int, SortedList<int, int>> ClearwayCorr = new()
        {
            { 200,  new SortedList<int, int> { { 100, -3 }, { 120, -3 },    { 140, -3 },    { 160, -2 } } },
            { 100,  new SortedList<int, int> { { 100, -2 }, { 120, -2 },    { 140, -2 },    { 160, -1 } } },
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
