using NUnit.Framework;
using System.Collections.Generic;


namespace MyMath.Tests
{
    public class OperationsTests
    {
        [Test]
        public void Max_nullListCheck()
        {
            List<int> nums = null;
            int returnValue;

            returnValue = Operations.Max(nums);

            Assert.AreEqual(0, returnValue);
        }

        [Test]
        public void Max_CheckEmptyList()
        {
            List<int> nums = new List<int>();
            int returnValue;

            returnValue = Operations.Max(nums);

            Assert.AreEqual(0, returnValue);
        }

        [Test]
        public void Max_ReturnValue()
        {
            List<int> nums = new List<int>() { 1, 5, -5, 88, 34, 0 };
            int returnValue;

            returnValue = Operations.Max(nums);

            Assert.AreEqual(88, returnValue);
        }
    }
}