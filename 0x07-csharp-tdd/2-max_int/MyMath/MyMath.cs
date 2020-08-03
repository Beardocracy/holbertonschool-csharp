using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Contains math methods.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Returns the max integer in a list of integers.
        /// </summary>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
            {
            return 0;
            }
            else
            {
                nums.Sort();

                return (nums[nums.Count - 1]);
            }
        }
    }
}
