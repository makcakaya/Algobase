namespace HackerRank
{
    public sealed class AppendAndDelete
    {
        public static bool Solution(string s, string t, int k)
        {
            var matchLength = 0;
            for (var i = 0; i < s.Length && i < t.Length; i++)
            {
                if (s[i] != t[i])
                {
                    break;
                }
                matchLength++;
            }

            var min = (s.Length - matchLength) + (t.Length - matchLength);
            var evennessConflict = min % 2 != k % 2;
            return evennessConflict ? k >= s.Length + t.Length : k >= min;
        }
    }
}