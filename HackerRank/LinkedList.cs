using Console_App.Models;

namespace Console_App.HackerRanks
{
	internal class LinkedList
	{
		public static OneWayNode insert(OneWayNode? head, int data)
		{
			//Complete this method
			OneWayNode created = new(data);
			if (head is null)
			{
				return created;
			}
			else
			{
				OneWayNode start = head;
				while (start != null)
				{
					if (start.next is null)
					{

						start.next = created;
						break;
					}
					start = start.next;
				}
				return head;
			}
		}
	}
}
