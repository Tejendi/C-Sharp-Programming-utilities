using System.Collections.Generic;
using Extensions.Extensions;
using NUnit.Framework;

namespace Tests.TestCases
{
    [TestFixture]
    public class StringExtensionTests
    {
        [Test()]
        public void TrimToLowerInvariant()
        {
            const string originalValue = "HellO WORLd   ";
            const string targetValue = "hello world";

            Assert.AreEqual(targetValue, originalValue.TrimToLowerInvariant());
        }

        [TestCase()]
        public void TrimToUpperInvariant()
        {
            const string originalValue = "HellO WORLd   ";
            const string targetValue = "HELLO WORLD";

            Assert.AreEqual(targetValue, originalValue.TrimToUpperInvariant());
        }

        [TestCase()]
        public void RemoveLastCharacter()
        {
            const string originalValue = "Hello world";
            const string targetValue = "Hello worl";

            Assert.AreEqual(targetValue, originalValue.RemoveLastCharacter());
        }

        [TestCase()]
        public void RemoveLast()
        {
            const string originalValue = "Hello world";
            const string targetValue = "Hello wor";

            Assert.AreEqual(targetValue, originalValue.RemoveLast(2));
        }

        [TestCase()]
        public void RemoveFirstCharacter()
        {
            const string originalValue = "Hello world";
            const string targetValue = "ello world";

            Assert.AreEqual(targetValue, originalValue.RemoveFirstCharacter());
        }

        [TestCase()]
        public void RemoveFirst()
        {
            const string originalValue = "Hello world";
            const string targetValue = "llo world";

            Assert.AreEqual(targetValue, originalValue.RemoveFirst(2));
        }

        [TestCase("3/9/2008")]
        [TestCase("Sunday, March 09, 2008")]
        [TestCase("Sunday, March 09, 2008 4:05 PM")]
        [TestCase("Sunday, March 09, 2008 4:05:07 PM")]
        [TestCase("3/9/2008 4:05 PM")]
        [TestCase("3/9/2008 4:05:07 PM")]
        [TestCase("Sun, 09 Mar 2008 16:05:07 GMT")]
        [TestCase("2008-03-09T16:05:07")]
        [TestCase("2008-03-09 16:05:07Z")]
        public void IsDate(string dateValue)
        {
            Assert.IsTrue(dateValue.IsDate());
        }

        [TestCase()]
        public void NullStringToEmptyString()
        {
            string nullString = null;

            Assert.AreEqual(string.Empty, nullString.NullStringToEmptyString());

        }
    }
}