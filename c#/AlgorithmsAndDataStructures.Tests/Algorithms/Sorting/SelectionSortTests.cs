using NUnit.Framework;
using AlgorithmsAndDataStructures.Algorithms.Sorting;
using System.Collections.Generic;

namespace AlgorithmsAndDataStructures.Tests.Algorithms.Sorting
{
    [TestFixture]
    public class SelectionSortTests
    {
        [Test]
        public void SimpleTestCase()
        {
            Assert.AreEqual(SelectionSort.Sort(SortTestData.TestData1), SortTestData.TestData1Sorted);
        }

        [Test]
        public void EmptyTestCase()
        {
            Assert.AreEqual(SelectionSort.Sort(SortTestData.TestData2), SortTestData.TestData2);
        }

        [Test]
        public void ModerateTestCase()
        {
            Assert.AreEqual(SelectionSort.Sort(SortTestData.TestData3), SortTestData.TestData3Sorted);
        }

        [Test]
        public void LargeTestCase()
        {
            Assert.AreEqual(SelectionSort.Sort(SortTestData.TestData4), SortTestData.TestData4Sorted);
        }
    }
}
