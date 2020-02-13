using System.Collections.Generic;
using Xunit;

namespace Codility.Tests
{
    public sealed class CountDivTest
    {
        [Fact]
        public void Solution()
        {
            var cases = new List<Case>
            {
                new Case(1, 10, 3, 3),
                new Case(0, 15, 5, 4),
                new Case(6, 11, 2, 3),
                new Case(0, 0, 1, 1),
                new Case(0, 0, 11, 1),
                new Case(10, 10, 5, 1),
                new Case(11, 14, 2, 2),
                new Case(11, 345, 17, 20)
            };

            foreach (var testCase in cases)
            {
                Assert.Equal(testCase.Result, CountDiv.Solution(testCase.A, testCase.B, testCase.K));
            }
            CountDiv.Solution(1, 10, 3);
        }

        public sealed class Case
        {
            public Case(int a, int b, int k, int result)
            {
                A = a;
                B = b;
                K = k;
                Result = result;
            }

            public int A { get; set; }
            public int B { get; set; }
            public int K { get; set; }
            public int Result { get; set; }
        }
    }
}