using NUnit.Framework;
using System.Collections.Generic;

namespace HackerRank.Tests
{
    [TestFixture]
    public sealed class CountTripletsTest
    {
        [Test]
        public void Solution()
        {
            var data = new List<dynamic>
            {
                new {Values = new List<long>{1,2,4,5}, Ratio = 2, Result = 1},
                new {Values = new List<long>{1,1,2,4}, Ratio = 2, Result = 2},
                new {Values = new List<long>{1,2,2,2}, Ratio = 2, Result = 0 },
                new {Values = new List<long>{4,2,2,4,4,1,1 }, Ratio =2, Result = 0 }
            };
            foreach (var d in data)
            {
                Assert.AreEqual(d.Result, CountTriplets.Solution(d.Values, d.Ratio));
            }
        }
    }
}