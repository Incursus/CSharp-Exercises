using NUnit.Framework;

namespace StringCapitalization.Tests
{
    [TestFixture]
    public class DetermineFirstLetterCapitalizationTests
    {
        [Test]
        public void ReturnsFalseIfNull()
        {
            var result = StringExtensions.DetermineFirstLetterCapitalization(userValue: null);

            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnsFalseIfEmptySpace()
        {
            var result = StringExtensions.DetermineFirstLetterCapitalization(userValue: "  ");

            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnsFalseIfEmpty()
        {
            var result = StringExtensions.DetermineFirstLetterCapitalization(userValue: "");

            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnsTrueIfLetterIsUpperCase()
        {
            var result = StringExtensions.DetermineFirstLetterCapitalization(userValue: "A");

            Assert.IsTrue(result);
        }

        [Test]
        public void ReturnsFalseIfLetterIsLowerCase()
        {
            var result = StringExtensions.DetermineFirstLetterCapitalization(userValue: "a");

            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnsFalseIfStartingWithNumber()
        {
            var result = StringExtensions.DetermineFirstLetterCapitalization(userValue: "7Up");
            
            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnsTrueIfUpperCaseWordStartsWithSpace()
        {
            var result = StringExtensions.DetermineFirstLetterCapitalization(userValue: " Amberino");

            Assert.IsTrue(result);
        }

        [Test]
        public void ReturnsTrueForWordStartingWithSingleQoute()
        {
            var result = StringExtensions.DetermineFirstLetterCapitalization(userValue: "'Tis");

            Assert.IsTrue(result);
        }

        [Test]
        public void ReturnsFalseIfStartsWithSpaceAndLowercase()
        {
            var result = StringExtensions.DetermineFirstLetterCapitalization(userValue: " test");

            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnsFalseIfStartsWithSingleQuoteAndLowercase()
        {
            var result = StringExtensions.DetermineFirstLetterCapitalization(userValue: "'test");

            Assert.IsFalse(result);
        }
    }
}
