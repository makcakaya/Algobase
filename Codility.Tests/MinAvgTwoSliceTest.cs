using Xunit;

namespace Codility.Tests
{
    public sealed class MinAvgTwoSliceTest
    {
        [Fact]
        public void Solution()
        {
            var result = MinAvgTwoSlice.Solution(new int[] { 4, 2, 2, 5, 1, 5, 8 });
            Assert.Equal(1, result);
        }
    }
}