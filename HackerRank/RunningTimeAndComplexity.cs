using Console_App.Utilities;
using System;
using System.Collections.Generic;

namespace Console_App.HackerRank
{
	internal class RunningTimeAndComplexity
	{
		public RunningTimeAndComplexity()
		{
			DateTime start = DateTime.Now;
			int testCases = ConsoleUtilities.IntRead();
			(string prime, string notPrime) = ("Prime", "Not prime");
			IList<string> list = [];
			while (testCases-- > 0)
			{
				int num = ConsoleUtilities.IntRead();
				bool isPrime = IsPrime(num);
				list.Add(isPrime ? prime : notPrime);
			}
			Console.WriteLine(string.Join('\n', list));
		}

		static bool IsPrime(int num)
		{
			if (num < 2) return false;
			if (num == 2) return true;
			if (num % 2 == 0) return false;
			int sqrt = (int)Math.Sqrt(num);
			for (int i = 3; i <= sqrt; i += 2)
			{
				if (num % i == 0) return false;
			}
			return true;
		}
	}
}
