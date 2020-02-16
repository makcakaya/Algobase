using System.Collections.Generic;

namespace Codility
{
    public sealed class Nesting
    {
        public static int Solution(string value)
        {
            var stack = new Stack<char>();
            foreach (var c in value)
            {
                if (c == '(')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return 0;
                    }
                    stack.Pop();
                }
            }
            return stack.Count == 0 ? 1 : 0;
        }
    }
}