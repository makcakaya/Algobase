using System.Collections.Generic;
using Xunit;

namespace Codility.Tests
{
    public sealed class DistinctTest
    {
        [Fact]
        public void Solution()
        {
            var data = new List<dynamic>
            {
                new {Values = new int[] {-1, -4, 0, 1, -1, 0, 40, 100}, Result = 6 },
                new {Values = new int[] {}, Result = 0 },
                new {Values = new int[] {-1, -1, 0, -1, 0}, Result = 2 }
            };

            foreach (var d in data)
            {
                Assert.Equal(d.Result, Distinct.Solution(d.Values));
            }
        }
    }
}