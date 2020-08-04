using System;

namespace Text
{
    /// <summary>
    /// Contains the CamelCase method.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Determines how many words are in a string.
        /// </summary>
        public static int CamelCase(string s)
        {
            if (s == null || s.Length == 0)
            {
                return 0;
            }
            int count = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
