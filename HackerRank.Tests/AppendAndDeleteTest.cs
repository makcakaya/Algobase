using NUnit.Framework;
using System.Collections.Generic;

namespace HackerRank.Tests
{
    [TestFixture]
    public sealed class AppendAndDeleteTest
    {
        [Test]
        public void Solution()
        {
            var data = new List<dynamic>
            {
                new {S = "abc", T = "def", K = 6, Result = true},
                new {S = "ashley", T = "ash", K = 2, Result = false},
                new {S = "aba", T = "aba", K = 7, Result = true},
            };

            foreach (var d in data)
            {
                Assert.AreEqual(d.Result, AppendAndDelete.Solution(d.S, d.T, d.K));
            }
        }
    }
}