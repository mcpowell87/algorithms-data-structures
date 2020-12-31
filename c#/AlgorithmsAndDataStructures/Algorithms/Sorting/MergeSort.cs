using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Algorithms.Sorting
{
    /// <summary>
    /// Splits the input list in half, recursively sorts each half, then merges the lists back together.
    /// T: O(nlogn)
    /// S: O(n)
    /// </summary>
    public class MergeSort
    {
        public static List<int> Sort(List<int> array)
        {
            // Base case, return array of size 1
            if (array.Count <= 1)
            {
                return array;
            }

            // Split the array in half
            var mid = array.Count / 2;
            var left = new List<int>();
            var right = new List<int>();
            for (int i = 0; i < mid; i++)
            {
                left.Add(array[i]);
            }
            for (int i = mid; i < array.Count; i++)
            {
                right.Add(array[i]);
            }

            // Recursively call MergeSort
            var leftSorted = Sort(left);
            var rightSorted = Sort(right);

            return MergeArrays(leftSorted, rightSorted);
        }

        private static List<int> MergeArrays(List<int> leftArray, List<int> rightArray)
        {
            var leftIdx = 0;
            var rightIdx = 0;
            var merged = new List<int>();

            while (leftIdx < leftArray.Count || rightIdx < rightArray.Count)
            {
                if (leftIdx < leftArray.Count && rightIdx < rightArray.Count)
                {
                    if (leftArray[leftIdx] <= rightArray[rightIdx])
                    {
                        merged.Add(leftArray[leftIdx]);
                        leftIdx++;
                    }
                    else
                    {
                        merged.Add(rightArray[rightIdx]);
                        rightIdx++;
                    }
                }
                else if (leftIdx < leftArray.Count)
                {
                    merged.Add(leftArray[leftIdx]);
                    leftIdx++;
                }
                else if (rightIdx < rightArray.Count)
                {
                    merged.Add(rightArray[rightIdx]);
                    rightIdx++;
                }
            }

            return merged;
        }
    }
}
