using System.Collections.Generic;
using Xunit;

namespace Codility.Tests
{
    public sealed class TriangleTest
    {
        [Fact]
        public void Solution()
        {
            var data = new List<dynamic>()
            {
                new { Array = new int[3] { 0, 0, 0 }, Result = 0 },
                new { Array = new int[3] { 1, 2, 2 }, Result = 1 },
                new { Array = new int[2] { 0, 2 }, Result = 0 },
                new { Array = new int[6] { 10, 2, 5, 1, 8, 20 }, Result = 1 },
            };

            foreach (var d in data)
            {
                Assert.Equal(d.Result, Triangle.Solution(d.Array));
            }
        }
    }
}