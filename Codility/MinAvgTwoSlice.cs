namespace Codility
{
    public sealed class MinAvgTwoSlice
    {
        public static int Solution(int[] values)
        {
            var minAverage = float.MaxValue;
            var minIndex = 0;
            for (var i = 0; i < values.Length - 1; i++)
            {
                var average = (values[i] + values[i + 1]) / 2f;
                if (average < minAverage)
                {
                    minIndex = i;
                    minAverage = average;
                }
                if (i < values.Length - 2)
                {
                    var average3 = (values[i] + values[i + 1] + values[i + 2]) / 3f;
                    if (average3 < minAverage)
                    {
                        minIndex = i;
                        minAverage = average3;
                    }
                }
            }
            return minIndex;
        }
    }
}