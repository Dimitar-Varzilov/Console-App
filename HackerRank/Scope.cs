using System;
using System.Linq;

namespace Console_App.HackerRanks
{

	class Difference
	{
		private readonly int[] elements;
		public int maximumDifference;

		public Difference(int[] elements)
		{
			this.elements = elements;
		}

		public void computeDifference()
		{
			int diff = elements.Max() - elements.Min();
			maximumDifference = Math.Abs(diff);
		}
	}
	internal class Scope
	{
	}
}
