using System;

namespace Codility
{
    public sealed class PermCheck
    {
        public static int Solution(int[] array)
        {
            Array.Sort(array);
            var current = 1;
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] != current++)
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}