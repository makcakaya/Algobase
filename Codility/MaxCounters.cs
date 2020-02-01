using System.Collections.Generic;
using System.Linq;

namespace Codility
{
    public sealed class MaxCounters
    {
        public static int[] Solution(int countersLength, int[] operations)
        {
            // Calculate the max value until the last max counter operation
            var popularity = new Dictionary<int, int>();
            var lastMaxValue = 0;
            var lastMaxIndex = -1;
            for (var i = 0; i < operations.Length; i++)
            {
                var operation = operations[i];
                if (operation >= 1 && operation <= countersLength)
                {
                    var key = operation - 1;
                    var value = 0;
                    if (popularity.ContainsKey(key))
                    {
                        value = popularity[key];
                    }
                    popularity[key] = value + 1;
                }
                else if (operation == countersLength + 1)
                {
                    lastMaxIndex = i;
                    lastMaxValue += popularity.Any() ? popularity.Max(kv => kv.Value) : 0;
                    popularity.Clear();
                }
            }

            // Set all counters to the max value
            var counters = new int[countersLength];
            for (var i = 0; i < countersLength; i++)
            {
                counters[i] = lastMaxValue;
            }

            // Calculate the rest of the operations from the last max counter operation
            for (var i = lastMaxIndex + 1; i < operations.Length; i++)
            {
                var op = operations[i];
                if (op >= 1 && op <= countersLength)
                {
                    counters[op - 1]++;
                }
            }
            return counters;
        }
    }
}