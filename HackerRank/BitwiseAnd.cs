namespace Console_App.HackerRank
{
	internal static class BitwiseAnd
	{
		// Returns the maximum value of (a & b) < K for 0 < a < b < N
		public static int bitwiseAnd(int N, int K)
		{
			int max = 0;

			for (int a = 1; a <= N; a++)
			{
				for (int b = a + 1; b <= N; b++)
				{
					int val = a & b;
					if (val < K && val > max)
					{
						max = val;
					}
				}
			}
			return max;
		}
	}
}
