using System;

namespace Codility
{
    public sealed class Triangle
    {
        public static int Solution(int[] values)
        {
            if (values.Length < 3)
            {
                return 0;
            }
            Array.Sort(values);
            for (var i = 0; i < values.Length - 2; i++)
            {
                if (values[i] > values[i + 2] - values[i + 1])
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}