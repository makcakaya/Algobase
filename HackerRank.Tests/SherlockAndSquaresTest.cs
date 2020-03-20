using NUnit.Framework;
using System.Collections.Generic;

namespace HackerRank.Tests
{
    [TestFixture]
    public sealed class SherlockAndSquaresTest
    {
        [Test]
        public void Solution()
        {
            var data = new List<dynamic>
            {
                new {A = 24, B = 49, Result =3 }
            };

            foreach (var d in data)
            {
                Assert.AreEqual(d.Result, SherlockAndSquares.Solution(d.A, d.B));
            }
        }
    }
}