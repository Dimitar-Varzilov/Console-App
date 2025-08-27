using System;

namespace Console_App.Helpers
{
	internal class PercentCalculator
	{
		public double percentPart;
		public double loweredSum;
		public double increasedSum;
		public PercentCalculator() { }
		public PercentCalculator(double sum, int percent)
		{
			double newPercent = Convert.ToDouble(percent);
			percentPart = sum * (newPercent / 100);
			loweredSum = sum - percentPart;
			increasedSum = sum + percentPart;
		}
		public PercentCalculator(double sum, double percent)
		{
			percentPart = sum * (percent / 100);
			loweredSum = sum - percentPart;
			increasedSum = sum + percentPart;

		}
	}
}
