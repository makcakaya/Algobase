using System;

namespace HackerRank
{
    public sealed class SherlockAndSquares
    {
        public static int Solution(int a, int b)
        {
            var count = 0;
            var counter = Math.Floor(Math.Sqrt(a));
            while (true)
            {
                var squared = counter * counter;
                if (squared > b)
                {
                    break;
                }
                count += squared >= a && squared <= b ? 1 : 0;
                counter++;
            }
            return count;
        }
    }
}