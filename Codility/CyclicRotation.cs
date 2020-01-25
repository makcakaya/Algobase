namespace Codility
{
    public sealed class CyclicRotation
    {
        public int[] Solution(int[] array, int rotation)
        {
            var result = new int[array.Length];
            for (var i = 0; i < array.Length; i++)
            {
                var dest = (i + rotation) % array.Length;
                result[dest] = array[i];
            }
            return result;
        }
    }
}