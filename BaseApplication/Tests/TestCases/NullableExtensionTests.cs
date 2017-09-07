using Extensions.Extensions;
using NUnit.Framework;

namespace Tests.TestCases
{
    [TestFixture]
    public class NullableExtensionTests
    {
        [TestCase()]
        public void HasValueAndEquals()
        {
            int? notNullValue = 2;

            Assert.IsTrue(notNullValue.HasValueAndEquals(2));
        }

        [TestCase()]
        public void DoesNotHaveValue()
        {
            int? nullValue = null;

            Assert.IsFalse(nullValue.HasValueAndEquals(2));
        }


        [TestCase()]
        public void HasValueAndEqualsNullTarget()
        {
            int? nullValue = 2;

            Assert.IsFalse(nullValue.HasValueAndEquals(null));
        }

        [TestCase()]
        public void DoesNotHaveValueAndEqualsNullTarget()
        {
            int? nullValue = null;

            Assert.IsFalse(nullValue.HasValueAndEquals(null));
        }
    }
}
