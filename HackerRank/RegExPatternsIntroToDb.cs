using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_App.HackerRank
{
	internal class RegExPatternsIntroToDb
	{
		public RegExPatternsIntroToDb()
		{
			int N = Convert.ToInt32(Console.ReadLine().Trim());

			IList<(string firstName, string email)> emailBook = [];

			for (int NItr = 0; NItr < N; NItr++)
			{
				string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

				string firstName = firstMultipleInput[0];

				string emailID = firstMultipleInput[1];

				emailBook.Add((firstName, emailID));
			}
			emailBook
				.OrderBy(keyValuePair => keyValuePair.firstName)
				.Where(keyValuePair => keyValuePair.email.EndsWith("@gmail.com"))
				.Select(keyValuePair => keyValuePair.firstName)
				.ToList()
				.ForEach(Console.WriteLine);
		}
	}
}
