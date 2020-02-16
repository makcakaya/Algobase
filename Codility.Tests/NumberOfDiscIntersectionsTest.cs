using System.Collections.Generic;
using Xunit;

namespace Codility.Tests
{
    public sealed class NumberOfDiscIntersectionsTest
    {
        [Fact]
        public void Solution()
        {
            var data = new List<dynamic>
            {
                new {Radiuses = new int[]{3,2}, Result = 1},
                new {Radiuses = new int[]{1, 2147483647, 0}, Result = 2},
            };
            foreach (var d in data)
            {
                Assert.Equal(d.Result, NumberOfDiscIntersections.Solution(d.Radiuses));
            }
        }
    }
}