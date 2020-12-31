using System;
using System.Collections.Generic;

namespace AlgorithmsAndDataStructures.Algorithms.Sorting
{
	/// <summary>
	/// Inserts elements from an unsorted list into a sorted subsection of the list.
	/// T: O(n^2)
	/// S: O(1)
	/// </summary>
    public class InsertionSort
    {
		public static List<int> Sort(List<int> array)
		{
			for (int i = 1; i < array.Count; i++)
			{
				var j = i - 1;
				var cur = array[i];
				while (j >= 0 && cur < array[j])
				{
					array[j + 1] = array[j];
					j--;
				}
				array[j + 1] = cur;
			}
			return array;
		}
	}
}
