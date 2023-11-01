namespace Console_App
{
	static class ExtensionMethods
	{
		public static PercentCalc CalcPercent(this double sum, int percent)
		{
			return new PercentCalc(sum, percent); ;
		}
		public static PercentCalc CalcPercent(this double sum, double percent)
		{
			return new PercentCalc(sum, percent); ;
		}
		public static PercentCalc CalcPercent(this int sum, int percent)
		{
			return new PercentCalc(sum, percent); ;
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
}
