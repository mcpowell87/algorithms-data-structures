using System.Collections.Generic;
using NUnit.Framework;
using AlgorithmsAndDataStructures.Algorithms.Sorting;

namespace AlgorithmsAndDataStructures.Tests.Algorithms.Sorting
{
    [TestFixture]
    public class QuickSortTests
    {
        [Test]
        public void SimpleTestCase()
        {
            Assert.AreEqual(QuickSort.Sort(SortTestData.TestData1), SortTestData.TestData1Sorted);
        }

        [Test]
        public void EmptyTestCase()
        {
            Assert.AreEqual(QuickSort.Sort(SortTestData.TestData2), SortTestData.TestData2);
        }

        [Test]
        public void ModerateTestCase()
        {
            Assert.AreEqual(QuickSort.Sort(SortTestData.TestData3), SortTestData.TestData3Sorted);
        }

        [Test]
        public void LargeTestCase()
        {
            Assert.AreEqual(QuickSort.Sort(SortTestData.TestData4), SortTestData.TestData4Sorted);
        }
    }
}
