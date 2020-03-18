using System.Numerics;

namespace HackerRank
{
    public sealed class ExtraLongFactorials
    {
        public static string Solution(int n)
        {
            var result = new BigInteger(n);
            for (var i = 1; i < n; i++)
            {
                result = BigInteger.Multiply(result, new BigInteger(n - i));
            }
            return result.ToString();
        }
    }
}