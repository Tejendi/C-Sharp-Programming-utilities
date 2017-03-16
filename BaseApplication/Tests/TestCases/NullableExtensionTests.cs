using Extensions.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.TestCases
{
    [TestClass]
    public class NullableExtensionTests
    {
        [TestMethod]
        public void HasValueAndEquals()
        {
            int? notNullValue = 2;

            Assert.IsTrue(notNullValue.HasValueAndEquals(2));
        }

        [TestMethod]
        public void DoesNotHaveValue()
        {
            int? nullValue = null;

            Assert.IsFalse(nullValue.HasValueAndEquals(2));
        }


        [TestMethod]
        public void HasValueAndEqualsNullTarget()
        {
            int? nullValue = 2;

            Assert.IsFalse(nullValue.HasValueAndEquals(null));
        }

        [TestMethod]
        public void DoesNotHaveValueAndEqualsNullTarget()
        {
            int? nullValue = null;

            Assert.IsFalse(nullValue.HasValueAndEquals(null));
        }
    }
}
