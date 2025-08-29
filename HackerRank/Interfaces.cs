using System.Collections.Generic;
using System.Linq;

namespace Console_App.HackerRank
{
	internal class Interfaces
	{
		public int divisorSum(int n)
		{
			IList<int> divisors = [];
			for (int i = 1; i <= n; i++)
			{
				if (n % i == 0)
				{
					divisors.Add(i);
				}
			}
			return divisors.Sum();
		}
	}
}
