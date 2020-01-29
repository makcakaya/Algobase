using System;
using System.Linq;

namespace Codility
{
    public sealed class MissingInteger
    {
        public int Solution(int[] array)
        {
            array = array.Distinct().ToArray();
            Array.Sort(array);
            var current = 1;
            for (var i = 0; i < array.Length; i++)
            {
                var elem = array[i];
                if (elem <= 0)
                {
                    continue;
                }
                if (elem != current)
                {
                    return current;
                }
                current++;
            }
            return current;
        }
    }
}