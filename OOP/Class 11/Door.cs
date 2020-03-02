using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Door
	{
		public Colours Colour { get; set; }
		public double Height { get; set; }
		public double Width { get; set; }

		public Door(Colours colour,double height,double width)
		{
			Colour = colour;
			Height = height;
			Width = width;
		}

		public Door()
		{ }

		public override string ToString()
		{
			return $"Door properties:\nColour:{Colour}\nHeight:{Height}\nWidth:{Width}";	
		}
	}
}
