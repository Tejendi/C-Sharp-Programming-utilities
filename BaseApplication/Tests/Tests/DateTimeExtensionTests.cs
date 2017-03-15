using System;
using Extensions.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Tests
{
    [TestClass]
    public class DateTimeExtensionTests
    {
        [TestMethod]
        public void IsToday()
        {
            DateTime currentDate = DateTime.Now;
            DateTime yesterday = DateTime.Now.AddDays(-1);

            Assert.IsTrue(currentDate.IsToday());
            Assert.IsFalse(yesterday.IsToday());
        }

        [TestMethod]
        public void IsBetween()
        {
            DateTime startDate = new DateTime(2000, 01, 01);
            DateTime endDate = new DateTime(2001, 12, 31);
            DateTime selectedDate = new DateTime(2000, 03, 03);

            Assert.IsTrue(selectedDate.IsBetween(startDate, endDate));
        }
    }
}
