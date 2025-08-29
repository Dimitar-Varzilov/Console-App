using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_App.HackerRanks
{
	internal class Inheritance
	{
	}

	class Person
	{
		protected string firstName;
		protected string lastName;
		protected int id;

		public Person() { }
		public Person(string firstName, string lastName, int identification)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
		}
		public void printPerson()
		{
			Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
		}
	}

	// Replace the invalid gradingScale initialization in Student class with a valid Dictionary initialization
	class Student(string firstName, string lastName, int id, int[] testScores) : Person(firstName, lastName, id)
	{
		private static readonly Dictionary<string, (int, int)> gradingScale = new()
		{
			{ "O", (90, 100) },
			{ "E", (80, 89) },
			{ "A", (70, 79) },
			{ "P", (55, 69) },
			{ "D", (40, 54) },
			{ "T", (0, 39) }
		};

		public string Calculate()
		{
			int scoresSum = testScores.Sum();
			int average = testScores.Length > 0 ? scoresSum / testScores.Length : 0;
			foreach (KeyValuePair<string, (int, int)> grade in gradingScale)
			{
				if (average >= grade.Value.Item1 && average <= grade.Value.Item2)
					return grade.Key;
			}
			return gradingScale.Last().Key;
		}
	}
}
