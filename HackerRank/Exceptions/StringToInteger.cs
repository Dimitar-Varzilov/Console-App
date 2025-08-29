using System;

namespace Console_App.HackerRank.Exceptions
{
	internal class StringToInteger
	{
		public StringToInteger()
		{
			try
			{
				string S = Console.ReadLine() ?? throw new NullReferenceException();
				int result = int.Parse(S);
				Console.WriteLine(result);
			}
			catch
			{
				Console.WriteLine("Bad String");
			}
		}
	}
}
