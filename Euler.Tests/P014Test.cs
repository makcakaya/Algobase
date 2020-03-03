using NUnit.Framework;
using System;

namespace Euler.Tests
{
    [TestFixture]
    public sealed class P014Test
    {
        [Test]
        public void Solve()
        {
            var result = P014.Solve();
            Console.WriteLine(result);
        }
    }
}