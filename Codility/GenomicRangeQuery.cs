using System;

namespace Codility
{
    public sealed class GenomicRangeQuery
    {
        public static int[] Solution(string gen, int[] p, int[] q)
        {
            const int NucCount = 4;
            var emptyRow = new int[] { 0, 0, 0, 0 };
            var occurrences = new int[gen.Length][];
            for (var i = 0; i < gen.Length; i++)
            {
                var nuc = gen[i];
                var col = 0;
                switch (nuc)
                {
                    case 'A':
                        col = 0;
                        break;

                    case 'C':
                        col = 1;
                        break;

                    case 'G':
                        col = 2;
                        break;

                    case 'T':
                        col = 3;
                        break;
                }
                var prevRow = i == 0 ? new int[NucCount] : occurrences[i - 1];
                occurrences[i] = new int[NucCount];
                Array.Copy(prevRow, occurrences[i], prevRow.Length);
                occurrences[i][col]++;
            }

            var result = new int[p.Length];
            for (var i = 0; i < p.Length; i++)
            {
                var lowIndex = p[i] - 1;
                var highIndex = q[i];
                var lowRow = lowIndex < 0 ? emptyRow : occurrences[lowIndex];
                var highRow = occurrences[highIndex];
                for (var col = 0; col < NucCount; col++)
                {
                    if (highRow[col] > lowRow[col])
                    {
                        result[i] = col + 1;
                        break;
                    }
                }
            }
            return result;
        }
    }
}