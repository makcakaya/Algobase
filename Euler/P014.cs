using System.Collections.Generic;

namespace Euler
{
    public sealed class P014
    {
        private readonly static int Limit = 1000000;

        public static int Solve()
        {
            var maxSequenceCount = 0;
            var maxStart = 0;
            var processed = new HashSet<int>();
            for (var i = Limit; i > 1; i--)
            {
                if (processed.Contains(i)) { continue; }
                var count = Collatz(i, processed);
                if (count > maxSequenceCount)
                {
                    maxSequenceCount = count;
                    maxStart = i;
                }
            }
            return maxStart;
        }

        public static int Collatz(long value, HashSet<int> processed)
        {
            var count = 0;
            while (value != 1)
            {
                if (value <= Limit)
                {
                    processed.Add((int)value);
                }
                value = value % 2 == 0 ? (value / 2) : value * 3 + 1;
                count++;
            }
            return count;
        }
    }
}