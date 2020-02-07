using Xunit;

namespace Codility.Tests
{
    public sealed class GenomicRangeQueryTests
    {
        [Fact]
        public void Solution()
        {
            var result = GenomicRangeQuery.Solution("ACGTTAC", new int[] { 0 }, new int[] { 4 });
            Assert.Equal(new int[] { 1 }, result);
        }
    }
}