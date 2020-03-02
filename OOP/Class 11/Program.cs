using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			Coordinate_Struct testStruct = new Coordinate_Struct(1,2,3);
			Console.WriteLine(testStruct);
			Door testDoor = new Door(Colours.Black, 2, 3);
			Console.WriteLine(testDoor);
			ChangeX(testStruct, 666);
			Console.WriteLine("Changing X in Structure");
			Console.WriteLine(testStruct);
			ChangeHeight(testDoor, 444);
			Console.WriteLine("Changing Height of a Door");
			Console.WriteLine(testDoor);
			Coordinate_Struct copy = CopyCoordinate(testStruct);
			Console.WriteLine("Copy of a Structure");
			Console.WriteLine(copy);
			Door copyDoor = CopyDoor(testDoor);
			Console.WriteLine("Copy of a door");
			copyDoor.Colour = Colours.Magenta;
			Console.WriteLine(testDoor.Colour);
		}

		public static void ChangeX(Coordinate_Struct Structure,double x)
		{
			Structure.X = x;
		}

		public static void ChangeHeight(Door door,double height)
		{
			door.Height = height;
		}

		public static Coordinate_Struct CopyCoordinate(Coordinate_Struct coordinateToCopy)
		{
			Coordinate_Struct copy = coordinateToCopy;
			return copy;
		}

		public static Door CopyDoor(Door doorToCopy)
		{
			Door copyDoor = new Door();
			copyDoor.Colour = doorToCopy.Colour;
			copyDoor.Height = doorToCopy.Height;
			copyDoor.Width = doorToCopy.Width;
			return copyDoor;
		}
	}
}
