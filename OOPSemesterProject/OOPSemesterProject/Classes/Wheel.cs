using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSemesterProject
{
	class Wheel : CarPart, Classes.IGetDescription
	{
		public double Diameter { get; set; }

		public override string ToString()
		{
			return string.Format($"ID: {ID}   Name: {Name}");
		}

		public override string GetDescription()
		{
			return $"ID: {ID} \r\nManufacturer: {Manufacturer}\r\nDescription: {Description}\r\nPrice: {Price}\r\nDiameter: {Diameter}";
		}
	}
}
