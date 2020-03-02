using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_14
{
	class Program
	{
		static void Main(string[] args)
		{
			//var testQueue = new Queue<Cube>();
			//testQueue.AddToTheQueue(new Cube(1,2,3));
			//testQueue.AddToTheQueue(new Cube(3, 4, 5));
			//testQueue.AddToTheQueue(new Cube(5, 6, 7));
			//Console.WriteLine(testQueue.Exists(new Cube(8, 7, 6)));
			//Console.WriteLine(testQueue.Exists(new Cube(1, 2, 3)));
			//testQueue.Sort();
			//testQueue.Peek();
			//testQueue.Dequeue();
			//testQueue.Peek();
			//testQueue.Dequeue();
			//testQueue.Peek();
			//testQueue.Dequeue();

			var testQueue = new Queue<Person>();
			testQueue.AddToTheQueue(new Person(1,"Alex",21));
			testQueue.AddToTheQueue(new Person(2, "Mike", 33));
			testQueue.AddToTheQueue(new Person(3, "John", 25));
			testQueue.Sort();
			testQueue.Peek();
			testQueue.Dequeue();
			testQueue.Peek();
			testQueue.Dequeue();
			testQueue.Peek();
			testQueue.Dequeue();
		}
	}
}
