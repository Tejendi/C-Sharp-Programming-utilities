using System;
using Extensions.Extensions;
using NUnit.Framework;

namespace Tests.TestCases
{
    [TestFixture]
    public class DateTimeExtensionTests
    {
        [TestCase()]
        public void IsDateToday()
        {
            DateTime currentDate = DateTime.Now;

            Assert.IsTrue(currentDate.IsToday());
        }

        [TestCase()]
        public void IsDateNotToday()
        {
            DateTime yesterday = DateTime.Now.AddDays(-1);

            Assert.IsFalse(yesterday.IsToday());
        }

        [TestCase()]
        public void IsDateBetween()
        {
            DateTime startDate = new DateTime(2000, 01, 01);
            DateTime endDate = new DateTime(2001, 12, 31);
            DateTime selectedDate = new DateTime(2000, 03, 03);

            Assert.IsTrue(selectedDate.IsBetween(startDate, endDate));
        }

        [TestCase()]
        public void IsDateNotBetween()
        {
            DateTime startDate = new DateTime(2000, 01, 01);
            DateTime endDate = new DateTime(2001, 12, 31);
            DateTime selectedDate = new DateTime(2005, 03, 03);

            Assert.IsFalse(selectedDate.IsBetween(endDate, startDate));
        }
    }
}