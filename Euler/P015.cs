namespace Euler
{
    public sealed class P015
    {
        public static long Solve(int n)
        {
            return CountPaths(n, 0, 0, new long[n, n]);
        }

        public static long CountPaths(long size, int row, int col, long[,] mem)
        {
            if (row == size || col == size) { return 1; }
            if (mem[row, col] == 0)
            {
                mem[row, col] = CountPaths(size, row + 1, col, mem) + CountPaths(size, row, col + 1, mem);
            }
            return mem[row, col];
        }
    }
}