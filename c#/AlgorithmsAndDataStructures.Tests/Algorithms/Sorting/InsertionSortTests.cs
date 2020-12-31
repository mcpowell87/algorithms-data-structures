using NUnit.Framework;
using AlgorithmsAndDataStructures.Algorithms.Sorting;
using System.Collections.Generic;

namespace AlgorithmsAndDataStructures.Tests.Algorithms.Sorting
{
    [TestFixture]
    class InsertionSortTests
    {
        [Test]
        public void SimpleTestCase()
        {
            Assert.AreEqual(InsertionSort.Sort(SortTestData.TestData1), SortTestData.TestData1Sorted);
        }

        [Test]
        public void EmptyTestCase()
        {
            Assert.AreEqual(InsertionSort.Sort(SortTestData.TestData2), SortTestData.TestData2);
        }

        [Test]
        public void ModerateTestCase()
        {
            Assert.AreEqual(InsertionSort.Sort(SortTestData.TestData3), SortTestData.TestData3Sorted);
        }

        [Test]
        public void LargeTestCase()
        {
            Assert.AreEqual(InsertionSort.Sort(SortTestData.TestData4), SortTestData.TestData4Sorted);
        }
    }
}
