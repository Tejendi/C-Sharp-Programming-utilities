using System.Collections.Generic;
using Extensions.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.Objects;

namespace Tests.TestCases
{
    [TestClass]
    public class EnumerableExtensionTests
    {
        [TestMethod]
        public void IntInList()
        {
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            const int intValue = 2;

            Assert.IsTrue(intValue.In(intList));
        }

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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