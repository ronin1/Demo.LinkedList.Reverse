using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
	public class Node<T>
	{
		public T Value { get; set; }
		public Node<T> Next { get; set; }
	}
}
