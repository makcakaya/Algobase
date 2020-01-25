using System.Collections.Generic;
using System.Linq;

namespace Codility
{
    public sealed class OddOccurrencesInArray
    {
        public static int Solution(int[] array)
        {
            var set = new HashSet<int>();
            foreach (var value in array)
            {
                if (set.Contains(value))
                {
                    set.Remove(value);
                }
                else
                {
                    set.Add(value);
                }
            }
            return set.ToArray()[0];
        }
    }
}