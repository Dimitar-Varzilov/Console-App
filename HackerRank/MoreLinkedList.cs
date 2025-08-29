using Console_App.Models;
using Console_App.Utilities;
using System;
using System.Collections.Generic;

namespace Console_App.HackerRank
{
	internal class MoreLinkedList
	{
		public static OneWayNode removeDuplicates(OneWayNode? head)
		{
			//HashSet<int> nodeData = [];
			//OneWayNode? currentNode = head;

			//while (currentNode != null)
			//{
			//	nodeData.Add(currentNode.data);
			//	currentNode = currentNode.next;
			//}

			//OneWayNode? res = null;
			//foreach (int i in nodeData)
			//{
			//	res = NodeUtilities.insert(res, i);
			//}
			//return res ?? throw new NullReferenceException();

			OneWayNode? current = head;
			while (current != null && current.next != null)
			{
				if (current.data == current.next.data)
				{
					current.next = current.next.next;
				}
				else
				{
					current = current.next;
				}
			}
			return head ?? throw new NullReferenceException();
		}
	}
}
