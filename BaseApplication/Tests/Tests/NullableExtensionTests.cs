using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensions.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.Objects;

namespace Tests.Tests
{
    [TestClass]
    public class NullableExtensionTests
    {
        [TestMethod]
        public void HasValueAndEquals()
        {
            int? nullValue = null;
            int? notNullValue = 2;

            Assert.IsFalse(nullValue.HasValueAndEquals(2));
            Assert.IsTrue(notNullValue.HasValueAndEquals(2));
        }


        [TestMethod]
        public void HasValueAndEqualsNullTarget()
        {
            int? nullValue = null;

            Assert.IsFalse(nullValue.HasValueAndEquals(2));
            Assert.IsFalse(nullValue.HasValueAndEquals(null));
        }
    }
}
