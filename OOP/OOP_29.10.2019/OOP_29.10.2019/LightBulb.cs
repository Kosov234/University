using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_29._10._2019
{
	public class LightBulb
	{

		private bool state;

		public Colours Colour { get; set; }

		public string Shape { get; set; }

		public bool State
		{
			get
			{
				return state;
			}

			set
			{
				state = value;
				Console.Write("New State Set: ");
				if (state)
				{
					Console.Write("On\nState: On\n");
				}
				else
				{
					Console.Write("Off\nState: Off\n");
				}
			}
		}

		public void PrintState()
		{
			if (state)
			{
				Console.Write("On\n");
			}
			else
			{
				Console.Write("Off\n");
			}
		}
	}
}
