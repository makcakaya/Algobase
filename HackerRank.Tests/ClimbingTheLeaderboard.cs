using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Tests
{
    public sealed class ClimbingTheLeaderboard
    {
        public static int[] Solution(int[] scores, int[] alice)
        {
            var board = new Dictionary<int, int>();
            foreach (var s in scores)
            {
                board[s] = board.ContainsKey(s) ? board[s] + 1 : 1;
            }

            var ranks = new int[alice.Length];
            var i = 0;
            var higherThan = 0;
            var keys = board.Keys.ToArray().OrderBy(k => k).ToArray();
            for (var k = 0; i < ranks.Length;)
            {
                if (k >= keys.Length)
                {
                    ranks[i++] = keys.Length + 1 - higherThan;
                    continue;
                }

                var score = keys[k];
                if (alice[i] >= score)
                {
                    higherThan++;
                    k++;
                }
                else
                {
                    ranks[i++] = keys.Length + 1 - higherThan;
                }
            }
            return ranks;
        }
    }
}