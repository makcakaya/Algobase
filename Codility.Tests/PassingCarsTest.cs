using Xunit;

namespace Codility.Tests
{
    public sealed class PassingCarsTest
    {
        [Fact]
        public void Solution()
        {
            var input = new int[] { 0, 1, 0, 1, 1 };
            var result = PassingCars.Solution(input);
            Assert.Equal(5, result);
        }
    }
}