using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
	class Program
	{
		static void Main(string[] args)
		{
			Menu();
		}

		public static void Menu()
		{
			IFillAndSum dataStructure;
			Console.WriteLine("What would you like to use?\n1.Array\n2.List");
			int input = int.Parse(Console.ReadLine());
			if (input == 1)
			{
				dataStructure = new Array();
				Console.WriteLine("Type numbers you want to sum:");
				dataStructure.Fill();
				dataStructure.Show();
				dataStructure.Sum();
			}
			else if(input == 2)
			{
				dataStructure = new List();
				Console.WriteLine("Type numbers you want to sum:");
				dataStructure.Fill();
				dataStructure.Show();
				dataStructure.Sum();
			}
			else
			{
				Console.Clear();
				Console.WriteLine("Invalid input!Try again!");
				Menu();
			}

		}
	}
}
