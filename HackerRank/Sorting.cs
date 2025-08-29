using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_App.HackerRank
{
	internal class Sorting
	{
		private static readonly IList<int> arr = [];
		private int numberOfSwaps = 0;
		public Sorting()
		{
			for (int i = 0; i < arr.Count; i++)
			{
				for (int j = 0; j < arr.Count - 1; j++)
				{
					// Swap adjacent elements if they are in decreasing order
					if (arr[j] > arr[j + 1])
					{
						swap(arr[j], arr[j + 1]);
						numberOfSwaps++;
					}
				}
			}

			Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
			Console.WriteLine($"First Element: {arr.First()}");
			Console.WriteLine($"Last Element: {arr.Last()}");

		}

		private static void swap(int a, int b)
		{
			int indexOfA = arr.IndexOf(a);
			if (indexOfA < 0) throw new KeyNotFoundException();

			arr[indexOfA] = b;
			arr[indexOfA + 1] = a;
		}
	}
}
