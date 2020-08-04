using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void UniqueChar_stringWithOne()
        {
            string str = "abcdefedcbda";
            int retVal = Str.UniqueChar(str);

            Assert.AreEqual(retVal, 5);
        }

        [Test]
        public void UniqueChar_noRepeaters()
        {
            string str = "abcdeedcda";
            int retVal = Str.UniqueChar(str);

            Assert.AreEqual(retVal, 1);
        }

        [Test]
        public void UniqueChar_nullString()
        {
            string str = null;
            int retVal = Str.UniqueChar(str);

            Assert.AreEqual(retVal, -1);
        }

        [Test]
        public void UniqueChar_emptyString()
        {
            string str = "";
            int retVal = Str.UniqueChar(str);

            Assert.AreEqual(retVal, -1);
        }

        [Test]
        public void UniqueChar_singleCharString()
        {
            string str = "t";
            int retVal = Str.UniqueChar(str);

            Assert.AreEqual(retVal, 0);
        }
    }
}