using System;

namespace Codility
{
    public sealed class Distinct
    {
        public static int Solution(int[] values)
        {
            Array.Sort(values);
            var count = 0;
            int? prev = null;
            foreach (var value in values)
            {
                if (value != prev)
                {
                    count++;
                    prev = value;
                }
            }
            return count;
        }
    }
}