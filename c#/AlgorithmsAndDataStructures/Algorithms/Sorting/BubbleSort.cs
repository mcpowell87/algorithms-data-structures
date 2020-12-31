using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsAndDataStructures.Algorithms.Sorting
{
    public class BubbleSort
    {
		public static List<int> Sort(List<int>array)
		{
			for (var i = 0; i < array.Count; i++)
			{
				for (var j = 0; j < array.Count - 1; j++)
				{
					if (array[j] > array[j + 1])
					{
						var temp = array[j];
						array[j] = array[j + 1];
						array[j + 1] = temp;
					}
				}
			}
			return array;
		}
	}
}
