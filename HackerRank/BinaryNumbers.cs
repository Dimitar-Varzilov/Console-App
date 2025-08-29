using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_App.HackerRanks
{
	internal class BinaryNumbers
	{
		public BinaryNumbers()
		{

			int n = Convert.ToInt32(Console.ReadLine()?.Trim());

			// Convert decimal to binary
			string binary = Convert.ToString(n, 2);
			const char one = '1';
			int currentCountOfOne = 0;
			List<int> numberOfOnes = [];
			foreach (char i in binary)
			{
				if (i == one) currentCountOfOne++;
				else if (currentCountOfOne > 0)
				{
					numberOfOnes.Add(currentCountOfOne);
					currentCountOfOne = 0;
				}
			}

			int correctedCountOfOnes = numberOfOnes.Count > 0 ? numberOfOnes.Max() : 0;

			Console.WriteLine(Math.Max(correctedCountOfOnes, currentCountOfOne));
		}
	}
}
