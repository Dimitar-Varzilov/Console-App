namespace Console_App.HackerRanks
{
	internal static class Recursion3
	{
		public static int Factorial(int n)
		{
			if (n > 1) return n * Factorial(n - 1);
			return 1;
		}
	}
}
