using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSemesterProject
{
	class Seat : CarPart, Classes.IGetDescription
	{
		public string Material { get; set; }
		public string Color { get; set; }

		public override string ToString()
		{
			return string.Format($"ID: {ID}\tName: {Name}\t");
		}

		public override string GetDescription()
		{
			return $"ID: {ID} \r\nManufacturer: {Manufacturer}\r\nDescription: {Description}\r\nPrice: {Price}\r\nMaterial: {Material}\r\n Colour: {Color}";
		}
	}
}
