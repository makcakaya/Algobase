using NUnit.Framework;
using System.Collections.Generic;

namespace HackerRank.Tests
{
    [TestFixture]
    public sealed class ExtraLongFactorialsTest
    {
        [Test]
        public void Solution()
        {
            var data = new List<dynamic>
            {
                new {N = 30, Result = "265252859812191058636308480000000" }
            };

            foreach (var d in data)
            {
                Assert.AreEqual(d.Result, ExtraLongFactorials.Solution(d.N));
            }
        }
    }
}