using Extensions.Extensions;
using NUnit.Framework;

namespace Tests.TestCases
{
    [TestFixture]
    public class IntigerExtensionTests
    {
        [TestCase()]
        public void IsBetween()
        {
            const int minValue = int.MinValue;
            const int maxValue = int.MaxValue;

            const int value = 333;

            Assert.IsTrue(value.IsBetween(minValue, maxValue));
        }

        [TestCase()]
        public void IsOdd()
        {
            const int value = 1;
            Assert.IsTrue(value.IsOdd());
        }

        [TestCase()]
        public void IsEven()
        {
            const int value = 2;
            Assert.IsTrue(value.IsEven());
        }
    }
}
