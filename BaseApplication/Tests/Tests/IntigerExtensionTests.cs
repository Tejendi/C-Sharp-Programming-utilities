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
    public class IntigerExtensionTests
    {
        [TestMethod]
        public void IsBetween()
        {
            const int minValue = int.MinValue;
            const int maxValue = int.MaxValue;

            const int value = 333;

            Assert.IsTrue(value.IsBetween(minValue, maxValue));
        }

        [TestMethod]
        public void IsOdd()
        {
            const int value = 1;
            Assert.IsTrue(value.IsOdd());
        }

        [TestMethod]
        public void IsEven()
        {
            const int value = 2;
            Assert.IsTrue(value.IsEven());
        }
    }
}
