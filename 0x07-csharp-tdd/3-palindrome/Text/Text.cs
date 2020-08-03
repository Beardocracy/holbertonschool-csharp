using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// Contains the method is palindrome.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Returns true if string is a palindrome or False if its not.
        /// </summary>
        public static bool IsPalindrome(string s)
        {
            if (s.Length < 2)
            {
                return true;
            }
            string lowercaseString = s.ToLower();
            List<char> cleanString = new List<char>();
            for (int i = 0; i < lowercaseString.Length; i++)
            {
                if (Char.IsLetter(lowercaseString[i]) || Char.IsNumber(lowercaseString[i]))
                {
                    cleanString.Add(lowercaseString[i]);
                }
            }
            
                        
            int left = 0;
            int right = cleanString.Count - 1;
            for ( ; left < right; left++, right--)
            {
                if (cleanString[left] != cleanString[right])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
