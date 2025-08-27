using Console_App.Models;
using System;

namespace Console_App.Utilities
{
	internal static class NodeUtilities
	{
		public static Node insert(Node? root, int data)
		{
			if (root == null) return new Node(data);
			else
			{
				Node cur;
				if (data <= root.data)
				{
					cur = insert(root.left, data);
					root.left = cur;
				}
				else
				{
					cur = insert(root.right, data);
					root.right = cur;
				}
				return root;
			}
		}

		public static OneWayNode insert(OneWayNode? head, int data)
		{
			OneWayNode p = new(data);


			if (head == null)
				head = p;
			else if (head.next == null)
				head.next = p;
			else
			{
				OneWayNode start = head;
				while (start.next != null)
					start = start.next;
				start.next = p;

			}
			return head;
		}

		public static void display(OneWayNode? head)
		{
			OneWayNode? start = head;
			while (start != null)
			{
				Console.Write(start.data + " ");
				start = start.next;
			}
		}
	}
}
