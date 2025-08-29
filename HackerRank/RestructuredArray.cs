using System;
using System.Collections.Generic;

namespace Console_App.HackerRanks
{
	internal static class RestructuredArray
	{
		private static int[,] ToTwoDimensionalArray(IList<int> source, int rowLength)
		{
			int rows = (int)Math.Ceiling((double)source.Count / rowLength);
			int[,] result = new int[rows, rowLength];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < rowLength; j++)
				{
					result[i, j] = source[i * rowLength + j];
				}
			}

			return result;
		}

		public static IList<int> GetElements(IList<int> arr, IList<IList<int>> queries)
		{
			if (arr.Count == 0 || queries.Count == 0) return [];
			int rowLength = arr[0];
			arr.RemoveAt(0);

			int[,] twoDimArray = ToTwoDimensionalArray(arr, rowLength);

			List<int> result = [];

			foreach (IList<int> query in queries)
			{
				int row = query[0];
				int column = query[1];
				try
				{
					result.Add(twoDimArray[row - 1, column - 1]);
				}
				catch
				{
					continue;
				}
			}

			return result;
		}

	}
}
