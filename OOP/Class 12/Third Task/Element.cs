using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
	class Element
	{
		public Element(int value)
		{
			Value = value;
		}

		public int Value { get; set; }
		public Element Next { get; set; }

	}
}
