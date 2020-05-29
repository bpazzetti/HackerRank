using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h30DaysOfCode
{
	class Day24_MoreLinkedLists
	{
		public class Node
		{
			public int data;
			public Node next;
			public Node(int d)
			{
				data = d;
				next = null;
			}

		}

		public static Node removeDuplicates(Node head)
		{
			Node next = head;
			do
			{
				//Write your code here
				Node node = next;
				int? value = node?.data;
				while (node != null)
				{
					if (node.next != null)
					{
						if (node.next.data == value)
						{							
							node.next = node.next.next;
						}						
						else
						{
							node = node.next;							
						}
					}
					else
					{
						node = node.next;
					}
				}
				next = next.next;				
			} while (next != null);
			return head;
		}

		public static Node insert(Node head, int data)
		{
			Node p = new Node(data);


			if (head == null)
				head = p;
			else if (head.next == null)
				head.next = p;
			else
			{
				Node start = head;
				while (start.next != null)
					start = start.next;
				start.next = p;

			}
			return head;
		}
		public static void display(Node head)
		{
			Node start = head;
			while (start != null)
			{
				Console.Write(start.data + " ");
				start = start.next;
			}
		}
		public static void Main1(String[] args)
		{

			Node head = null;
			int T = Int32.Parse(Console.ReadLine());
			while (T-- > 0)
			{
				int data = Int32.Parse(Console.ReadLine());
				head = insert(head, data);
			}
			head = removeDuplicates(head);
			display(head);
		}
	}
}
