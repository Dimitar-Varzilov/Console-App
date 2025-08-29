using System.Collections.Generic;

namespace Console_App.HackerRank
{
	internal class QueuesAndStacks
	{
		Queue<char> queue = [];
		Stack<char> stack = [];

		public void pushCharacter(char ch)
		{
			stack.Push(ch);
		}

		public void enqueueCharacter(char ch)
		{
			queue.Enqueue(ch);
		}

		public char popCharacter()
		{
			return stack.Pop();
		}

		public char dequeueCharacter()
		{
			return queue.Dequeue();
		}
	}
}
