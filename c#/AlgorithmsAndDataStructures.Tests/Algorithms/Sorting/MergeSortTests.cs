using System;
using System.Collections.Generic;
using AlgorithmsAndDataStructures.Algorithms.Sorting;
using NUnit.Framework;

namespace AlgorithmsAndDataStructures.Tests.Algorithms.Sorting
{
    [TestFixture]
    public class MergeSortTests
    {
        [Test]
        public void SimpleTestCase()
        {
            Assert.AreEqual(MergeSort.Sort(SortTestData.TestData1), SortTestData.TestData1Sorted);
        }

        [Test]
        public void EmptyTestCase()
        {
            Assert.AreEqual(MergeSort.Sort(SortTestData.TestData2), SortTestData.TestData2);
        }

        [Test]
        public void ModerateTestCase()
        {
            Assert.AreEqual(MergeSort.Sort(SortTestData.TestData3), SortTestData.TestData3Sorted);
        }

        [Test]
        public void LargeTestCase()
        {
            Assert.AreEqual(MergeSort.Sort(SortTestData.TestData4), SortTestData.TestData4Sorted);
        }
    }
}
