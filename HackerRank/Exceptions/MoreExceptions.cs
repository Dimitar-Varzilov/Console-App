using System;

namespace Console_App.HackerRank.Exceptions
{
	internal class Calculator
	{
		public int power(int n, int p)
		{
			if (n < 0 || p < 0) throw new ArgumentException("n and p should be non-negative");
			return (int)Math.Pow(n, p);
		}
	}
	internal class MoreExceptions
	{
		public MoreExceptions()
		{

		}
	}
}
