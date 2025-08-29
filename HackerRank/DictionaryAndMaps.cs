using System;
using System.Collections.Generic;

namespace Console_App.HackerRanks
{
	internal class DictionaryAndMaps
	{
		public DictionaryAndMaps()
		{
			Dictionary<string, int> phoneBook = [];
			int n = Convert.ToInt32(Console.ReadLine());
			IList<string> result = [];
			while (n > 0)
			{
				string? phone = Console.ReadLine();
				if (phone == null) break;

				string[] parts = phone.Split(' ');
				phoneBook.Add(parts[0], Convert.ToInt32(parts[1]));
				n--;
			}

			while (true)
			{
				string? name = Console.ReadLine();
				if (name == null) break;

				if (phoneBook.TryGetValue(name, out int phone))
				{
					result.Add($"{name}={phone}");
				}
				else
				{
					result.Add("Not found");
				}
			}

			Console.WriteLine(string.Join("\n", result));
		}
	}
}
