using Console_App.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_App.HackerRank
{
	internal class NestedLogic
	{
		public NestedLogic()
		{
			string returnDataInput = ConsoleUtilities.StringRead();
			IList<int> returnData = [..returnDataInput
				.Split(' ')
				.Select(int.Parse)];

			DateTime returnDate = new(returnData[2], returnData[1], returnData[0]);

			string dueDataInput = ConsoleUtilities.StringRead();
			IList<int> dueData = [..dueDataInput
				.Split(' ')
				.Select(int.Parse)];
			DateTime dueDate = new(dueData[2], dueData[1], dueData[0]);


			if (returnDate.Year > dueDate.Year)
			{
				Console.WriteLine(10000);
				return;
			}

			if (returnDate > dueDate)
			{
				if (returnDate.Month > dueDate.Month)
				{
					Console.WriteLine(500 * (returnDate.Month - dueDate.Month));
				}
				else
				{
					Console.WriteLine(15 * (returnDate.Day - dueDate.Day));
				}
			}
			else
			{
				Console.WriteLine(0);
			}
		}
	}
}
