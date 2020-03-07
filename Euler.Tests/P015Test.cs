using NUnit.Framework;

namespace Euler.Tests
{
    [TestFixture]
    public sealed class P015Test
    {
        [Test]
        public void Solve()
        {
            var count = P015.Solve(20);
            Assert.AreEqual(137846528820, count);
        }
    }
}