using NUnit.Framework;
using System.Collections.Generic;
using AlgorithmsAndDataStructures.Algorithms.Sorting;

namespace AlgorithmsAndDataStructures.Tests.Algorithms.Sorting
{
    [TestFixture]
    public class BubbleSortTests
    {
        [Test]
        public void SimpleTestCase()
        {
            Assert.AreEqual(BubbleSort.Sort(SortTestData.TestData1), SortTestData.TestData1Sorted);
        }

        [Test]
        public void EmptyTestCase()
        {
            Assert.AreEqual(BubbleSort.Sort(SortTestData.TestData2), SortTestData.TestData2);
        }

        [Test]
        public void ModerateTestCase()
        {
            Assert.AreEqual(BubbleSort.Sort(SortTestData.TestData3), SortTestData.TestData3Sorted);
        }

        [Test]
        public void LargeTestCase()
        {
            Assert.AreEqual(BubbleSort.Sort(SortTestData.TestData4), SortTestData.TestData4Sorted);
        }
    }
}
