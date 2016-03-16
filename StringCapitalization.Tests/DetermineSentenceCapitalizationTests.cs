using NUnit.Framework;

namespace StringCapitalization.Tests
{
    [TestFixture]
    public class DetermineSentenceCapitalizationTests
    {
        [Test]
        public void ReturnsFalseIfNull()
        {
            var result = StringExtensions.DetermineSentenceCapitalization(userValue: null);

            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnsFalseIfEmptySpace()
        {
            var result = StringExtensions.DetermineSentenceCapitalization(userValue: "  ");

            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnsFalseIfEmpty()
        {
            var result = StringExtensions.DetermineSentenceCapitalization(userValue: "");

            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnsTrueIfAllWordsStartWithUpper()
        {
            var result = StringExtensions.DetermineSentenceCapitalization(userValue: "Testing This Out");

            Assert.IsTrue(result);
        }

        [Test]
        public void ReturnsFalseIfOneWordStartsWithLower()
        {
            var result = StringExtensions.DetermineSentenceCapitalization(userValue: "Testing this Out");

            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnsFalseIfAllLowerCase()
        {
            var result = StringExtensions.DetermineSentenceCapitalization(userValue: "testing this out");

            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnsFalseIfDigitsAndAllStartWithUpper()
        {
            var result = StringExtensions.DetermineSentenceCapitalization(userValue: "8 Testing 7 This Out");

            Assert.IsFalse(result);
        }
    }
}