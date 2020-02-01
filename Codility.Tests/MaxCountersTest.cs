using System.Collections.Generic;
using Xunit;

namespace Codility.Tests
{
    public class MaxCountersTest
    {
        [Fact]
        public void Solution()
        {
            var testData = new List<Data>();
            testData.Add(new Data { CountersLength = 5, Operations = new int[] { 3, 4, 4, 6, 1, 4, 4 }, Result = new int[] { 3, 2, 2, 4, 2 } });
            testData.Add(new Data { CountersLength = 1, Operations = new int[] { }, Result = new int[] { 0 } });
            testData.Add(new Data { CountersLength = 2, Operations = new int[] { }, Result = new int[] { 0, 0 } });
            testData.Add(new Data { CountersLength = 2, Operations = new int[] { 1, 1, 1, 1, 3, 1, 1, 3, 1 }, Result = new int[] { 7, 6 } });
            testData.Add(new Data { CountersLength = 2, Operations = new int[] { 1, 1, 1, 1, 1, 1, 1, 2 }, Result = new int[] { 7, 1 } });
            testData.Add(new Data { CountersLength = 1, Operations = new int[] { 2, 1, 1, 2, 1 }, Result = new int[] { 3 } });
            foreach (var data in testData)
            {
                var result = MaxCounters.Solution(data.CountersLength, data.Operations);
                Assert.Equal(data.Result, result);
            }
        }

        private sealed class Data
        {
            public int CountersLength { get; set; }
            public int[] Operations { get; set; }
            public int[] Result { get; set; }
        }
    }
}