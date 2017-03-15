using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensions.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Tests
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
    }
}
