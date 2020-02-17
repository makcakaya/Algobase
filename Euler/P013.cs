using System.IO;

namespace Euler
{
    public sealed class P013
    {
        public static string Solve()
        {
            const int digitPerTake = 10;
            var inputLines = File.ReadAllLines(Path.Combine("Inputs", "P013Input.txt"));
            var startIndex = (inputLines[0].Length);
            long total = 0L;
            for (var i = 0; i < 5; i++)
            {
                total = 0;
                startIndex -= digitPerTake;
                foreach (var line in inputLines)
                {
                    var take = line.Substring(startIndex, digitPerTake);
                    var value = long.Parse(take);
                    total += value;
                }
                var totalStr = total.ToString();
                var remainder = totalStr.Substring(0, totalStr.Length - digitPerTake);
                if (!string.IsNullOrEmpty(remainder))
                {
                    total += int.Parse(remainder);
                }
            }
            return total.ToString().Substring(0, 10);
        }
    }
}