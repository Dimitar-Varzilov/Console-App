using System.Globalization;

namespace Console_App
{
	internal class Program
	{
		public static int IntRead()
		{
			int returnValue;
			while (true)
			{
				bool success = int.TryParse(Console.ReadLine()?.Trim(), out returnValue);
				if (!success)
				{
					Console.WriteLine("Invalid input");
					continue;
				}
				break;
			}
			return returnValue;
		}
		public static double DoubleRead()
		{
			double returnValue;
			while (true)
			{
				bool success = double.TryParse(Console.ReadLine()?.Trim(), out returnValue);
				if (!success)
				{
					Console.WriteLine("Invalid input");
					continue;
				}
				break;
			}
			return returnValue;
		}
		public static string? StringRead()
		{ return Console.ReadLine()?.Trim(); }


		static void Main()
		{

		}

	}
	internal static class ExtensionMethods
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

		public static bool IsBetween(this int value, int minimum, int maximum)
		{
			return value >= minimum && value <= maximum;
		}
		public static bool IsBetween(this double value, double minimum, double maximum)
		{
			return value >= minimum && value <= maximum;
		}
	}
	class PercentCalculator
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
