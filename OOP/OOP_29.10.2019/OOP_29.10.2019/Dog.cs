using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_29._10._2019
{
	class Dog
	{
		//private string name;
		private string race;
		private Colours colour;
		private double weight;
		private int age;

		public string Name	{ get; set;}

		public string Race {get; set;}

		public Colours Colour { get; set; }

		public double Weight
		{
			get
			{
				return weight;
			}

			set
			{
				if (value > 0)
				{
					weight = value;
				}
			}
		}

		public int Age
		{
			get
			{
				return age;
			}

			set
			{
				if (value > 0)
				{
					age = value;
				}
			}
		}

		public void WriteDogInfo()
		{
			Console.WriteLine("\nName: " + Name + "\nRace: " + Race + "\nColour: " + Colour + "\nWeight: " + Weight + "\nAge: " + Age + "\nDog Age: " + GetDogAge() + "\n");
		}

		public int GetDogAge()
		{
			return age * 7;
		}
	}
}
