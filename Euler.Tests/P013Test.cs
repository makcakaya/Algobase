using NUnit.Framework;
using System;

namespace Euler.Tests
{
    [TestFixture]
    public sealed class P013Test
    {
        [Test]
        public void Solution()
        {
            var result = P013.Solve();
            Console.WriteLine(result);
        }
    }
}