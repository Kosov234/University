﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSemesterProject.Classes
{
	public abstract class ShopElement
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Manufacturer { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }

		public abstract string GetDescription();
	}
}
