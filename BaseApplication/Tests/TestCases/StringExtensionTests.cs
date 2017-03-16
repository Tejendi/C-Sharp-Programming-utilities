using System.Collections.Generic;
using Extensions.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.TestCases
{
    [TestClass]
    public class StringExtensionTests
    {
        [TestMethod]
        public void TrimToLowerInvariant()
        {
            const string originalValue = "HellO WORLd   ";
            const string targetValue = "hello world";

            Assert.AreEqual(targetValue, originalValue.TrimToLowerInvariant());
        }

        [TestMethod]
        public void TrimToUpperInvariant()
        {
            const string originalValue = "HellO WORLd   ";
            const string targetValue = "HELLO WORLD";

            Assert.AreEqual(targetValue, originalValue.TrimToUpperInvariant());
        }

        [TestMethod]
        public void RemoveLastCharacter()
        {
            const string originalValue = "Hello world";
            const string targetValue = "Hello worl";

            Assert.AreEqual(targetValue, originalValue.RemoveLastCharacter());
        }

        [TestMethod]
        public void RemoveLast()
        {
            const string originalValue = "Hello world";
            const string targetValue = "Hello wor";

            Assert.AreEqual(targetValue, originalValue.RemoveLast(2));
        }

        [TestMethod]
        public void RemoveFirstCharacter()
        {
            const string originalValue = "Hello world";
            const string targetValue = "ello world";

            Assert.AreEqual(targetValue, originalValue.RemoveFirstCharacter());
        }

        [TestMethod]
        public void RemoveFirst()
        {
            const string originalValue = "Hello world";
            const string targetValue = "llo world";

            Assert.AreEqual(targetValue, originalValue.RemoveFirst(2));
        }

        [TestMethod]
        public void IsDate()
        {
            List<string> stringDateFormatList = new List<string>()
            {
                "3/9/2008",
                "Sunday, March 09, 2008",
                "Sunday, March 09, 2008 4:05 PM",
                "Sunday, March 09, 2008 4:05:07 PM",
                "3/9/2008 4:05 PM",
                "3/9/2008 4:05:07 PM",
                "Sun, 09 Mar 2008 16:05:07 GMT",
                "2008-03-09T16:05:07",
                "2008-03-09 16:05:07Z",
            };

            foreach (string stringValue in stringDateFormatList)
            {
                Assert.IsTrue(stringValue.IsDate());
            }
        }

        [TestMethod]
        public void NullStringToEmptyString()
        {
            string nullString = null;
            string emptyString = "";

            Assert.AreEqual(emptyString, nullString.NullStringToEmptyString());

        }
    }
}