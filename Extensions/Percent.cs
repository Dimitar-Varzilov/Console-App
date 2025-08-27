using Console_App.Helpers;

namespace Console_App.Extensions
{
	internal static class Percent
	{
		public static PercentCalculator CalculatePercent(this double sum, int percent)
		{
			return new PercentCalculator(sum, percent); ;
		}
		public static PercentCalculator CalculatePercent(this double sum, double percent)
		{
			return new PercentCalculator(sum, percent); ;
		}
		public static PercentCalculator CalculatePercent(this int sum, int percent)
		{
			return new PercentCalculator(sum, percent); ;
		}
	}
}
