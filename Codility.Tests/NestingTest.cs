using System.Collections.Generic;
using Xunit;

namespace Codility.Tests
{
    public sealed class NestingTest
    {
        [Fact]
        public void Solution()
        {
            var data = new List<dynamic>
            {
                new {Value = "()()()", Result = 1},
                new {Value = "", Result = 1},
                new {Value = "()(())()", Result = 1},
                new {Value = "((()))", Result = 1},
                new {Value = "()((()))()()", Result = 1},
                new {Value = "(()()", Result = 0},
                new {Value = "(", Result = 0},
                new {Value = "))", Result = 0},
                new {Value = "())", Result = 0}
            };
            foreach (var d in data)
            {
                Assert.Equal(d.Result, Nesting.Solution(d.Value));
            }
        }
    }
}