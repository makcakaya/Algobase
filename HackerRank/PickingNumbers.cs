using System;
using System.Collections.Generic;

namespace HackerRank
{
    public sealed class PickingNumbers
    {
        public static int Solution(List<int> a)
        {
            var counts = new Dictionary<int, int>();
            foreach (var i in a)
            {
                counts[i] = counts.ContainsKey(i) ? counts[i] + 1 : 1;
            }

            var maxTotal = 0;
            foreach (var kv in counts)
            {
                maxTotal = Math.Max(maxTotal, kv.Value);
                if (counts.ContainsKey(kv.Key + 1))
                {
                    maxTotal = Math.Max(maxTotal, kv.Value + counts[kv.Key + 1]);
                }
            }
            return maxTotal;
        }
    }
}