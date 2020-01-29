using System.Collections.Generic;

namespace Codility
{
    public sealed class FrogRiverOne
    {
        public static int Solution(int distance, int[] leaves)
        {
            var missingSteps = new HashSet<int>();
            for (var i = 1; i <= distance; i++)
            {
                missingSteps.Add(i);
            }

            for (var i = 0; i < leaves.Length; i++)
            {
                if (missingSteps.Contains(leaves[i]))
                {
                    missingSteps.Remove(leaves[i]);
                }
                if (missingSteps.Count == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}