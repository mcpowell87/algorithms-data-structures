using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsAndDataStructures.Algorithms.Sorting
{
    /// <summary>
    /// Divide and conquer sorting algorithm that picks an element as a pivot and partitions the given array around the pivot so that
    /// smaller items are on the left of the pivot and larger items are on the right.
    /// </summary>
    public class QuickSort
    {
        public static List<int> Sort(List<int> array)
        {
            Quick(array, 0, array.Count - 1);
            return array;
        }

        private static void Quick(List<int> array, int low, int high)
        {
            if (low < high)
            {
                var pi = Partition(array, low, high);

                Quick(array, low, pi - 1);
                Quick(array, pi + 1, high);
            }
        }

        private static int Partition(List<int> array, int low, int high)
        {
            var pivot = array[high];
            var i = (low - 1);
            for (var j = low; j <= high - 1; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    var t = array[j];
                    array[j] = array[i];
                    array[i] = t;
                }
            }
            var temp = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp;

            return (i + 1);
        }
    }
}
