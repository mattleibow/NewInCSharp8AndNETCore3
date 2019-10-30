using System;
using System.Collections.Generic;
using System.Linq;

namespace NewFeaturesDemo
{
    public class IndicesAndRanges
    {
        public void DemonstrateIndices()
        {
            var array = new[] { "A", "B", "C", "D", "E", "F", "G", "H" };


            var first = array[0]; // 0: A

            var last = array[^1]; // Length-1: H
        }
        public void DemonstrateRanges()
        {
            var array = new[] { "A", "B", "C", "D", "E", "F", "G", "H" };


            var middleStart = array[3..6]; // slice 3 to 6: D, E, F

            var middle = array[3..^2]; // slice 3 to Length-2: D, E, F

            var middleEnd = array[^5..^2]; // slice Length-5 to Length-2: D, E, F


            var fromStartToStart = array[..3]; // slice 0 to 3: A, B, C

            var fromStartFromEnd = array[..^5]; // slice 0 to Length-5: A, B, C

            var fromStartToEnd = array[5..]; // slice 5 to Length: F, G, H

            var fromEndToEnd = array[^3..]; // slice Length-3 to Length: F, G, H
        }

        public void CustomIndices()
        {
            var from0 = GetRelativeTo1To10(3); // 0+3: 3

            var backFrom10 = GetRelativeTo1To10(^3); // 10-3: 7
        }

        public void CustomRanges()
        {
            var rangeArray = GetRangeArray(3..7).ToArray(); // 3, 4, 5, 6, 7
        }

        public IEnumerable<int> GetRangeArray(Range range)
        {
            var start = range.Start.Value;
            var end = range.End.Value;

            for (var i = start; i < end + 1; i++)
            {
                yield return i;
            }
        }

        public int GetRelativeTo1To10(Index idx)
        {
            if (idx.IsFromEnd)
                return 10 - idx.Value;

            return 0 + idx.Value;
        }
    }
}
