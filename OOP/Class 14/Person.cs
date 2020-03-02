using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_14
{
	class Person : IComparable
	{
		private int id;
		private string name;
		private int age;

		public Person(int ID,string Name,int Age)
		{
			id = ID;
			name = Name;
			age = Age;
		}

		public override bool Equals(object obj)
		{
			Person second = obj as Person;
			if (second != null)
				if (id == second.id)
					return true;
			return false;
		}

		public override string ToString()
		{
			return string.Format($"ID: {id},Name: {name},Age: {age}");
		}

		public int CompareTo(object obj)
		{
			Person second = obj as Person;
			if (second != null)
			{
				if (age > second.age)
					return -1;
				if (age < second.age)
					return 1;
			}
			return 0;
		}
	}
}
