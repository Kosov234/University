using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP07_11_2019
{
	class Computer
	{
		public Computer(double monitorWidth,double MonitorHeight):
			this(monitorWidth, MonitorHeight, "undefined", Colours.Black)
		{
		}
		public Computer(double MonitorWidth, double MonitorHeight, string Brand, Colours Colour)
		{
			brand = Brand;
			this.Colour = Colour;
			monitorHeight = MonitorHeight;
			monitorWidth = MonitorWidth;
		}
		private string brand;
		public string Brand
		{
			get { return brand; }
			set
			{
				if (!String.IsNullOrWhiteSpace(value))
				{
					brand = value;
				}
				else
				{
					Console.WriteLine("Wrong Brand input!!!!");
				}
			}
		}

		public Colours Colour{ get; set; }
		double monitorWidth;
		public double MonitorWidth
		{
			get { return monitorWidth; }
			set
			{
				if (value > 0)
				{
					monitorWidth = value;
				}
				else
				{
					Console.WriteLine("Wrong Monitor Width input!!!!");
				}
			}
		}
		private double monitorHeight;
		public double MonitorHeight
		{
			get { return monitorHeight; }
			set
			{
				if (value > 0)
				{
					monitorHeight = value;
				}
				else
				{
					Console.WriteLine("Wrong Monitor Height input!!!!");
				}
			}
		}

		public string GetComputerInfo()
		{
			var data = new StringBuilder();
			data.AppendLine($"Brand: {Brand}");
			data.AppendLine($"Colour: {Colour}");
			data.AppendLine($"Monitor Width: {MonitorWidth}");
			data.AppendLine($"Monitor Height: {MonitorHeight}");

			return data.ToString();
		}
		public double CalculateMonitorArea()
		{
			return MonitorHeight * MonitorWidth;
		}
		public Computer Clone()
		{
			return new Computer(monitorWidth,MonitorHeight,brand,Colour);
			
		}
	}
}
