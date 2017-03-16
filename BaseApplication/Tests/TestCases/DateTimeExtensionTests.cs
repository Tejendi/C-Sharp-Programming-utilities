using System;
using Extensions.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.TestCases
{
    [TestClass]
    public class DateTimeExtensionTests
    {
        [TestMethod]
        public void IsDateToday()
        {
            DateTime currentDate = DateTime.Now;

            Assert.IsTrue(currentDate.IsToday());
        }

        [TestMethod]
        public void IsDateNotToday()
        {
            DateTime yesterday = DateTime.Now.AddDays(-1);

            Assert.IsFalse(yesterday.IsToday());
        }

        [TestMethod]
        public void IsDateBetween()
        {
            DateTime startDate = new DateTime(2000, 01, 01);
            DateTime endDate = new DateTime(2001, 12, 31);
            DateTime selectedDate = new DateTime(2000, 03, 03);

            Assert.IsTrue(selectedDate.IsBetween(startDate, endDate));
        }

        [TestMethod]
        public void IsDateNotBetween()
        {
            DateTime startDate = new DateTime(2000, 01, 01);
            DateTime endDate = new DateTime(2001, 12, 31);
            DateTime selectedDate = new DateTime(2005, 03, 03);

            Assert.IsFalse(selectedDate.IsBetween(endDate, startDate));
        }
    }
}