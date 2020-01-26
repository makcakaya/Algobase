using System;
using System.Linq;

namespace Codility
{
    public sealed class TapeEquilibrium
    {
        public static int Solution(int[] array)
        {
            var right = array.Sum();
            var left = 0;
            var minDif = int.MaxValue;
            for (var i = 0; i < array.Length - 1; i++)
            {
                left += array[i];
                right -= array[i];
                var dif = Math.Abs(left - right);
                minDif = Math.Min(dif, minDif);
            }
            return minDif;
        }
    }
}