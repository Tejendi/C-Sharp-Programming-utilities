using System.Collections.Generic;
using Extensions.Extensions;
using NUnit.Framework;
using Tests.Objects;

namespace Tests.TestCases
{
    [TestFixture]
    public class ObjectExtensionTests
    {
        [TestCase()]
        public void ToDictionary()
        {
            TestObject testObject = new TestObject { Name = "Test Object", Age = 123 };
            IDictionary<string, object> propertyDictionary = testObject.PropertiesToDictionary();

            Assert.AreEqual(propertyDictionary[nameof(testObject.Name)], testObject.Name);
            Assert.AreEqual(propertyDictionary[nameof(testObject.Age)], testObject.Age);
        }

        [TestCase()]
        public void PropertiesToDictionaryValueOfType()
        {
            TestObject testObject = new TestObject { Name = "Test Object", Age = 123 };
            IDictionary<string, string> propertyDictionary = testObject.PropertiesToDictionaryValueOfType<string>();

            Assert.AreEqual(propertyDictionary[nameof(testObject.Name)], testObject.Name);
            Assert.AreNotEqual(propertyDictionary[nameof(testObject.Age)], testObject.Age);
        }
    }
}
