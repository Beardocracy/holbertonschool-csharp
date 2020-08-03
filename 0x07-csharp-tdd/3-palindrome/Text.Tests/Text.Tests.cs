using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void IsPalindrome_EmptyString()
        {
            string emptyString = "";
            bool returnValue;

            returnValue = Str.IsPalindrome(emptyString);
            Assert.IsTrue(returnValue);
        }
        
        [Test]
        public void IsPalindrome_StringOfLengthOne()
        {
            string emptyString = "Z";
            bool returnValue;

            returnValue = Str.IsPalindrome(emptyString);
            Assert.IsTrue(returnValue);
        }

        [Test]
        public void IsPalindrome_NotPalindrome()
        {
            string emptyString = "ZX";
            bool returnValue;

            returnValue = Str.IsPalindrome(emptyString);
            Assert.IsFalse(returnValue);
        }

        [Test]
        public void IsPalindrome_SimplePalindrome_Test()
        {
            string emptyString = "level";
            bool returnValue;

            returnValue = Str.IsPalindrome(emptyString);
            Assert.IsTrue(returnValue);
        }

        [Test]
        public void IsPalindrome_CaseInsensitive_Test()
        {
            string emptyString = "Level";
            bool returnValue;

            returnValue = Str.IsPalindrome(emptyString);
            Assert.IsTrue(returnValue);
        }

        [Test]
        public void IsPalindrome_PunctuationIgnored_Test1()
        {
            string emptyString = "A man, a plan, a canal: Panama.";
            bool returnValue;

            returnValue = Str.IsPalindrome(emptyString);
            Assert.IsTrue(returnValue);
        }

        [Test]
        public void IsPalindrome_PunctuationIgnored_Test2()
        {
            string emptyString = "Racecar..";
            bool returnValue;

            returnValue = Str.IsPalindrome(emptyString);
            Assert.IsTrue(returnValue);
        }

        [Test]
        public void IsPalindrome_WithNumbers1()
        {
            string emptyString = "9Racecar9..";
            bool returnValue;

            returnValue = Str.IsPalindrome(emptyString);
            Assert.IsTrue(returnValue);
        }

        [Test]
        public void IsPalindrome_WithNumbers2()
        {
            string emptyString = "9Racecar0..";
            bool returnValue;

            returnValue = Str.IsPalindrome(emptyString);
            Assert.IsFalse(returnValue);
        }
    }
}