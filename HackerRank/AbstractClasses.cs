using System;

namespace Console_App.HackerRanks
{
	abstract class Book(string t, string a)
	{

		protected string title = t;
		protected string author = a;

		public abstract void Display();


	}
	internal class MyBook(string title, string author, int price): Book(title, author)
	{
		public override void Display()
		{
			Console.WriteLine($"Title: {title}");
			Console.WriteLine($"Author: {author}");
			Console.WriteLine($"Price: {price}");
		}
	}
	internal class AbstractClasses
	{
	}
}
