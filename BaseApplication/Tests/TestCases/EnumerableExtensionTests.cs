using System.Collections.Generic;
using Extensions.Extensions;
using NUnit.Framework;
using Tests.Objects;


namespace Tests.TestCases
{
    [TestFixture]
    public class EnumerableExtensionTests
    {
        [TestCase()]
        public void IntInList()
        {
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            const int intValue = 2;

            Assert.IsTrue(intValue.In(intList));
        }

        [TestCase()]
        public void ObjectInList()
        {
            List<TestObject> testObjectList = new List<TestObject>()
            {
                new TestObject {Name = "Test Test", Age = 1},
                new TestObject {Name = "Daniel Christensen", Age = 30},
                new TestObject {Name = "Unit Test", Age = 12},
            };

            Assert.IsTrue(testObjectList[1].In(testObjectList));
        }

        [TestCase()]
        public void FindMinValue()
        {
            List<TestObject> testObjectList = new List<TestObject>()
            {
                new TestObject {Name = "Test Test", Age = 1},
                new TestObject {Name = "Daniel Christensen", Age = 30},
                new TestObject {Name = "Unit Test", Age = 12},
            };

            TestObject minAge = testObjectList.FindMin(o => o.Age);
            Assert.AreEqual(1, minAge.Age);
        }

        [TestCase()]
        public void FindMinValueWhereAllIsMin()
        {
            List<TestObject> testObjectList = new List<TestObject>()
            {
                new TestObject {Name = "Test Test", Age = 1},
                new TestObject {Name = "Daniel Christensen", Age = 1},
                new TestObject {Name = "Unit Test", Age = 1},
            };

            TestObject minAge = testObjectList.FindMin(o => o.Age);
            Assert.AreEqual(1, minAge.Age);
        }

        [TestCase()]
        public void FindMaxValue()
        {
            List<TestObject> testObjectList = new List<TestObject>()
            {
                new TestObject {Name = "Test Test", Age = 1},
                new TestObject {Name = "Daniel Christensen", Age = 30},
                new TestObject {Name = "Unit Test", Age = 12},
            };

            TestObject maxAge = testObjectList.FindMax(o => o.Age);
            Assert.AreEqual(30, maxAge.Age);
        }

        [TestCase()]
        public void FindMaxValueWhereAllIsMax()
        {
            List<TestObject> testObjectList = new List<TestObject>()
            {
                new TestObject {Name = "Test Test", Age = 30},
                new TestObject {Name = "Daniel Christensen", Age = 30},
                new TestObject {Name = "Unit Test", Age = 30},
            };

            TestObject maxAge = testObjectList.FindMax(o => o.Age);
            Assert.AreEqual(30, maxAge.Age);
        }
    }
}