using System;

namespace Console_App.HackerRank
{
	internal class Generics
	{
		public Generics() 
		{
			
		}

		public static void PrintArray<T>(T[] array)
		{
			foreach (var item in array)
			{
				Console.WriteLine(item);
			}
		}
	}
}
