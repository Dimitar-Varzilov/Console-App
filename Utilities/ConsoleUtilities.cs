using System;
using System.Collections.Generic;

namespace Console_App.Utilities
{
	internal static class ConsoleUtilities
	{
		public static int IntRead()
		{
			while (true)
			{
				bool success = int.TryParse(Console.ReadLine()?.Trim(), out int returnValue);
				if (!success)
				{
					Console.WriteLine("Invalid Integer");
					continue;
				}
				return returnValue;
			}
		}
		public static double DoubleRead()
		{
			while (true)
			{
				bool success = double.TryParse(Console.ReadLine()?.Trim(), out double returnValue);
				if (!success)
				{
					Console.WriteLine("Invalid Double");
					continue;
				}
				return returnValue;
			}
		}
		public static string StringRead(string? cancelationString = null, List<string>? stringList = null)
		{
			while (true)
			{
				string? input = Console.ReadLine();
				if (input == null)
				{
					Console.WriteLine("Invalid String");
					continue;
				}
				stringList?.Add(input);
				if (cancelationString != null && input != cancelationString)
					continue;
				else if (stringList != null)
					continue;

				return input;
			}
		}

	}
}
