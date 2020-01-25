namespace Codility
{
    public sealed class PermMissingElem
    {
        public static int Solution(int[] array)
        {
            var n = array.Length + 1L;
            var total = n * (n + 1) / 2;
            var sum = 0L;
            for (var i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return (int)(total - sum);
        }
    }
}