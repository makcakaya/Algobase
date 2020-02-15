using System;

namespace Codility
{
    public sealed class MaxProductOfThree
    {
        public static int Solution(int[] values)
        {
            var n = values.Length;
            if (n < 3)
            {
                return 0;
            }

            Array.Sort(values);
            if (values[n - 1] < 0)
            {
                return values[n - 1] * values[n - 2] * values[n - 3];
            }
            else
            {
                var botTwoMult = values[0] * values[1];
                var topTwoMult = values[n - 2] * values[n - 3];
                var greatTwo = values[0] < 0 && botTwoMult > topTwoMult ? botTwoMult : topTwoMult;
                return greatTwo * values[n - 1];
            }
        }
    }
}