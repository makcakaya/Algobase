using NUnit.Framework;
using System.Collections.Generic;

namespace HackerRank.Tests
{
    [TestFixture]
    public sealed class PickingNumbersTest
    {
        [Test]
        public void Solution()
        {
            var data = new List<dynamic>
            {
                new {Arr = new List<int>{1,1,2,2,2,4,4,4,6,6,6,6,7,7,7,8 }, Result =7  }
            };

            foreach (var d in data)
            {
                Assert.AreEqual(d.Result, PickingNumbers.Solution(d.Arr));
            }
        }
    }
}