using System;

namespace Console_App
{
	internal class ConsoleReads
	{
		public static int IntRead()
		{ return Convert.ToInt32(Console.ReadLine()?.Trim()); }

		public static double DoubleRead()
		{ return Convert.ToDouble(Console.ReadLine()?.Trim()); }

		public static string StringRead()
		{ return Console.ReadLine()!.Trim(); }
	}
}
