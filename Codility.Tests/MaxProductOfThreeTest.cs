using System.Collections.Generic;
using Xunit;

namespace Codility.Tests
{
    public sealed class MaxProductOfThreeTest
    {
        [Fact]
        public void Solution()
        {
            var data = new List<dynamic>
            {
                new {Values = new int[]{-10, 0, 0, 1, 4, 9, -8 }, Result = 720},
                new {Values = new int[]{100, 0, 0, 1, 4, 9 }, Result = 3600},
                new {Values = new int[]{-10, -20, -30, 0, 1, 4, 9, -8 }, Result = 5400},
                new {Values = new int[]{-10, -20, -30, -4 }, Result = -800}
            };

            foreach (var d in data)
            {
                Assert.Equal(d.Result, MaxProductOfThree.Solution(d.Values));
            }
        }
    }
}