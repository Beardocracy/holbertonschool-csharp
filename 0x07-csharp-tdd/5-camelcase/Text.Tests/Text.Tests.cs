using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void CamelCase_nullString()
        {
            string str = null;
            int retVal = Str.CamelCase(str);

            Assert.AreEqual(0, retVal);
        }

        [Test]
        public void CamelCase_emptyString()
        {
            string str = "";
            int retVal = Str.CamelCase(str);

            Assert.AreEqual(0, retVal);
        }

        [Test]
        public void CamelCase_oneWord()
        {
            string str = "thisisntcamelcase";
            int retVal = Str.CamelCase(str);

            Assert.AreEqual(1, retVal);
        }

        [Test]
        public void CamelCase_twoWords()
        {
            string str = "camelCase";
            int retVal = Str.CamelCase(str);

            Assert.AreEqual(2, retVal);
        }
    }
}