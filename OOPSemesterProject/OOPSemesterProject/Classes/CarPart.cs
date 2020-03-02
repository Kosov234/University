using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSemesterProject
{

	public class CarPart: Classes.ShopElement,Classes.IGetDescription
	{
		

		public override string ToString()
		{
			return string.Format($"ID: {ID}\nName: {Name}\nManufacturer: {Manufacturer}\nDescription: {Description}\nPrice: {Price}");
		}

		public override string GetDescription()
		{
			return string.Format($"ID: {ID}\r\nName: {Name}\r\nManufacturer: {Manufacturer}\r\nDescription: {Description}\r\nPrice: {Price}");
		}
	}
}
