using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_App.HackerRanks
{
	internal class _2DArrays
	{
		public _2DArrays()
		{
			List<List<int>> arr = [];

			for (int i = 0; i < 6; i++)
			{
				arr.Add([.. Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp))]);
			}

			int rows = arr.Count;
			int columns = arr[0].Count;
			IList<int> sums = [];

			for (int rowIndex = 0; rowIndex <= arr.Count / 2; rowIndex++)
			{
				for (int columnIndex = 0; columnIndex <= columns / 2; columnIndex++)
				{
					int topLeft = arr[rowIndex][columnIndex];
					int topCenter = arr[rowIndex][columnIndex + 1];
					int topRight = arr[rowIndex][columnIndex + 2];
					int middleCenter = arr[rowIndex + 1][columnIndex + 1];
					int bottomLeft = arr[rowIndex + 2][columnIndex];
					int bottomCenter = arr[rowIndex + 2][columnIndex + 1];
					int bottomRight = arr[rowIndex + 2][columnIndex + 2];
					int[] ints = [topLeft, topCenter, topRight, middleCenter, bottomLeft, bottomCenter, bottomRight];
					sums.Add(ints.Sum());
				}
			}

			Console.WriteLine(sums.Max());
		}
	}
}
