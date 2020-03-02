using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_14
{
	class Queue<T> where T : IComparable
	{
		private List<T> queue = new List<T>();

		public void AddToTheQueue(T value)
		{
			queue.Add(value);
		}

		public void Dequeue()
		{
			queue.RemoveAt(0);
		}

		public void Peek()
		{
			Console.WriteLine($"Your top element is : {queue[0]}");
		}

		public bool Exists(T value)
		{
			for (int i = 0; i < queue.Count; i++)
			{
				if (queue[i].Equals(value))
					return true;
			}
			return false;
		}

		public void Sort()
		{
				queue.Sort();
		}
	}
}
