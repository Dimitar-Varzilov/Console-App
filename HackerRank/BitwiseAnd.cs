using System.Collections.Generic;
using System.Linq;

namespace Console_App.HackerRank
{
	internal static class BitwiseAnd
	{
		public static int bitwiseAnd(int N, int K)
		{
			IList<int> values = [.. Enumerable.Range(0, N)];
			HashSet<int> res = [];

			for (int i = 0; i < values.Count - 1; i++)
			{
				for (int j = 0; j < values.Count - 1; j++)
				{
					int bitWiseAnd = values[i] & values[j];
					if (bitWiseAnd < K)
					{
						res.Add(bitWiseAnd);
					}
				}
			}
			return res.Max();
		}
	}
}
