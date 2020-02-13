namespace Codility
{
    public sealed class CountDiv
    {
        public static int Solution(int a, int b, int k)
        {
            var divisibleFactor = a % k == 0 ? 1 : 0;
            return b / k - a / k + divisibleFactor;
        }
    }
}