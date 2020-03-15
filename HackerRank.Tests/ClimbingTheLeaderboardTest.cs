using NUnit.Framework;
using System.Collections.Generic;

namespace HackerRank.Tests
{
    [TestFixture]
    public sealed class ClimbingTheLeaderboardTest
    {
        [Test]
        public void Solution()
        {
            var data = new List<dynamic>
            {
                //new {Scores = new int[]{10, 30, 20, 100}, Alice = new int[]{5, 15, 40, 50}, Result = new int[]{5, 4,2,2 } },
                //new {Scores = new int[]{100, 100, 50, 40, 40, 20, 10}, Alice = new int[]{5, 25, 50, 120}, Result = new int[]{6,4,2,1} }
                new {Scores = new int[]{1}, Alice = new int[]{1,1}, Result = new int[]{1,1} }
            };

            foreach (var d in data)
            {
                Assert.AreEqual(d.Result, ClimbingTheLeaderboard.Solution(d.Scores, d.Alice));
            }
        }
    }
}