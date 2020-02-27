using System.Collections.Generic;

namespace HackerRank
{
    public sealed class CountTriplets
    {
        public static long Solution(List<long> arr, long r)
        {
            var t2 = new Dictionary<long, long>();
            var t3 = new Dictionary<long, long>();
            var result = 0L;
            foreach (var val in arr)
            {
                t3.TryGetValue(val, out var existing);
                result += existing;
                if (t2.ContainsKey(val))
                {
                    t3.TryGetValue(val * r, out var t3Existing);
                    t3[val * r] = t3Existing + t2[val];
                }
                t2.TryGetValue(val * r, out var t2Existing);
                t2[val * r] = t2Existing + 1;
            }
            return result;
        }
    }
}