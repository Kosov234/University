using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Product
	{
		public int Id { get;private set; }
		public string Name { get;private set; }
		public double Price { get;private set; }
		public EnumColor Color { get;private set; }

		public Product(int id,string name,double price,EnumColor color)
		{
			Id = id;
			Name = name;
			Price = price;
			Color = color;
		}

		public override string ToString()
		{
			return $"ID: {Id},Name:{Name},Price:{Price},Color{Color}";
		}
	}
}
