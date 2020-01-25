using System;

namespace Codility
{
    public sealed class FrogJmp
    {
        public static int Solution(int position, int destination, int distance)
        {
            return (int)Math.Ceiling((double)(destination - position) / distance);
        }
    }
}