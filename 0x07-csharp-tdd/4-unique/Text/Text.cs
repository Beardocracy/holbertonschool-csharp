using System;
using System.Collections.Generic;


namespace Text
{
    /// <summary>
    /// Contains the string method UniqueChar
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Returns the index of the first non-repeating character of a string.
        /// </summary>
        public static int UniqueChar(string s)
        {
            if (s == null || s.Length == 0)
            {
                return -1;
            }
            if (s.Length == 1)
            {
                return 0;
            }
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    dict[s[i]]++;
                }
                else
                {
                    dict.Add(s[i], 1);
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (dict[s[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
