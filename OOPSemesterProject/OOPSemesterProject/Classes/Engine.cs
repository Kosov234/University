using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSemesterProject
{
	class Engine : CarPart,Classes.IGetDescription
	{
		public int HorsePower { get; set; }

		public override string ToString()
		{
			return $"ID: {ID}\tName: {Name}";
		}

		public override string GetDescription()
		{
			return $"ID: {ID} \r\nManufacturer: {Manufacturer}\r\nDescription: {Description}\r\nPrice: {Price}\r\nHorsepower: {HorsePower}";
		}
	}
}
