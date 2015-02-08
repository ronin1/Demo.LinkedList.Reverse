using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
	class Program
	{
		static Node<T> BuildList<T>(T[] values)
		{
			if (values == null || values.Length == 0)
				return null;

			var last = new Node<T> { Value = values[0] };
			Node<T> head = last;

            for (int i=1; i<values.Length; i++)
			{
				var n = new Node<T> { Value = values[i] };
				last.Next = n;
				last = n;
			}
			return head;
        }

		static Node<T> Reverse<T>(Node<T> head)
		{
			if (head == null)
				return null;

			Node<T> last = null;
			Node<T> cur = head;
			while(cur != null)
			{
				Node<T> next = cur.Next;
				cur.Next = last;
				last = cur;
				cur = next;
			}
			return last;
		}

		static void PrintList<T>(Node<T> head, string msg = null)
		{
			Console.WriteLine();
			if(!string.IsNullOrEmpty(msg))
				Console.Write(msg);

			Node<T> cur = head;
			while (cur != null)
			{
				if (cur.Value == null)
					Console.Write("<null>");
				else
					Console.Write(cur.Value);

				if (cur.Next != null)
					Console.Write(" ~~> ");

				cur = cur.Next;
			}
			Console.WriteLine();
		}

		static void Main(string[] args)
		{
			Node<string> list = BuildList(args);
			PrintList(list, "Original: ");

			Node<string> reveresed = Reverse(list);
			PrintList(reveresed, "Reversed: ");
			PrintList(list, "Original: ");

#if DEBUG
			Console.ReadKey();
#endif
		}
	}
}
