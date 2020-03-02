using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_14
{
	class Cube :IComparable
	{
		private double height;
		private double width;
		private double depth;

		public Cube(double Height,double Width,double Depth)
		{
			height = Height;
			width = Width;
			depth = Depth;
		}

		public int CompareTo(object obj)
		{
			Cube second = obj as Cube;
			if (second != null)
			{
				if (height * width * depth < second.depth * second.height * second.width)
					return -1;
				if (height * width * depth > second.depth * second.height * second.width)
					return 1;
			}
			return 0;
		}

		public override bool Equals(object obj)
		{
			Cube second = obj as Cube;
			if (second != null)
				if (height * width * depth == second.depth * second.height * second.width)
					return true;
			return false;
		}

		public override string ToString()
		{
			return string.Format($"Cube size is {height * width * depth}");
		}
	}
}
