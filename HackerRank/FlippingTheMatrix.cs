using System;
using System.Collections.Generic;

namespace Console_App.HackerRanks
{
	internal static class FlippingTheMatrix
	{
		public static int FlipAndSum(IList<IList<int>> matrix)
		{
			int rows = matrix.Count;
			int columns = matrix[0].Count;
			int sum = 0;

			for (int rowIndex = 0; rowIndex < rows / 2; rowIndex++)
			{
				for (int columnIndex = 0; columnIndex < columns / 2; columnIndex++)
				{
					int topLeft = matrix[rowIndex][columnIndex];
					int topRight = matrix[rowIndex][columns - columnIndex - 1];
					int bottomLeft = matrix[rows - rowIndex - 1][columnIndex];
					int bottomRight = matrix[rows - rowIndex - 1][columns - columnIndex - 1];

					sum += Math.Max(Math.Max(topLeft, topRight), Math.Max(bottomLeft, bottomRight));
				}
			}

			return sum;
		}
	}
}
