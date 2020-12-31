using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsAndDataStructures.Algorithms.Sorting
{
	/// <summary>
	/// Selection sort repeatedly selects the next smallest element in the unsorted list and moves it to the front.
	/// T: O(n^2)
	/// S: O(1)
	/// </summary>
    public class SelectionSort
    {
		public static List<int> Sort(List<int> array)
		{
			for (var i = 0; i < array.Count; i++)
			{
				var smallest = i;
				for (var j = i; j < array.Count; j++)
				{
					if (array[smallest] > array[j])
					{
						smallest = j;
					}
				}
				var temp = array[i];
				array[i] = array[smallest];
				array[smallest] = temp;
			}
			return array;
		}
	}
}
