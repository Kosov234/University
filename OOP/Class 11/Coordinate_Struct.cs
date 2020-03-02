using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	public struct Coordinate_Struct
	{
		public double X { get;set; }
		public double Z { get;set; }
		public double Y { get;set; }

		public Coordinate_Struct(double x,double z,double y)
		{
			X = x;
			Z = z;
			Y = y;
		}

		public override string ToString()
		{
			return $"Structure properties:\nX:{X}\nZ:{Z}\nY:{Y}";
		}
	}
}
