namespace Console_App
{
	internal class Program : ConsoleReads
	{
		static void Main()
		{
			
		}
	}

	internal static class ExtensionMethods
	{
		public static PercentCalculator CalcPercent(this double sum, int percent)
		{
			return new PercentCalculator(sum, percent); ;
		}
		public static PercentCalculator CalcPercent(this double sum, double percent)
		{
			return new PercentCalculator(sum, percent); ;
		}
		public static PercentCalculator CalcPercent(this int sum, int percent)
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

	internal class ConsoleReads
	{
		public static int IntRead()
		{ return Convert.ToInt32(Console.ReadLine()?.Trim()); }

		public static double DoubleRead()
		{ return Convert.ToDouble(Console.ReadLine()?.Trim()); }

		public static string StringRead()
		{ return Console.ReadLine()!.Trim(); }
	}

	class PercentCalculator
	{
		public double persentPart;
		public double loweredSum;
		public double increasedSum;
		public PercentCalculator() { }
		public PercentCalculator(double sum, int percent)
		{
			double newPercent = Convert.ToDouble(percent);
			persentPart = sum * (newPercent / 100);
			loweredSum = sum - persentPart;
			increasedSum = sum + persentPart;
		}
		public PercentCalculator(double sum, double percent)
		{
			persentPart = sum * (percent / 100);
			loweredSum = sum - persentPart;
			increasedSum = sum + persentPart;

		}
	}
}
