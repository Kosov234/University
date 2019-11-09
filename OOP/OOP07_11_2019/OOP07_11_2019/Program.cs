using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP07_11_2019
{
	class Program
	{
		static void Main(string[] args)
		{
			//FirstTask();
			/*Computer TestPC = new Computer();
			TestPC.Brand = "Lenovo";
			TestPC.Colour = Colours.Black;
			TestPC.MonitorHeight = 1080;
			TestPC.MonitorWidth = 1920;
			SecondTaskGetComputerInfo(TestPC);*/
			/*Computer TestPCSecond = new Computer();
			TestPCSecond.Brand = "";
			TestPCSecond.Colour = Colours.Black;
			TestPCSecond.MonitorHeight = -1080;
			TestPCSecond.MonitorWidth = -1920;
			SecondTaskGetComputerInfo(TestPCSecond);*/
			/*Computer ThirdPC = new Computer(1920,1080);
			Console.WriteLine("Monitor area is: " + ThirdPC.CalculateMonitorArea());
			SecondTaskGetComputerInfo(ThirdPC);*/
			Computer FourthPC = new Computer(720, 440, "CoolBrandName", Colours.White);
			SecondTaskGetComputerInfo(FourthPC);
			Computer FifthPC = FourthPC.Clone();
			SecondTaskGetComputerInfo(FifthPC);
		}

		public static void FirstTask()
		{
			Computer PC = new Computer(1920,1080);
			PC.Brand = "Lenovo";
			Console.WriteLine(PC.GetComputerInfo());
		}
		public static void SecondTaskGetComputerInfo(Computer PC)
		{
			Console.WriteLine(PC.GetComputerInfo());
		}
	}
}
