using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
	class List : IFillAndSum
	{
		private List<string> stringList = new List<string>();


		public void Fill()
		{
			string input = Console.ReadLine();
			while (input.ToLower() != "done")
			{
				stringList.Add(input);
				input = Console.ReadLine();
			}
		}

		public void Show()
		{
			foreach (var element in stringList)
			{
				Console.WriteLine(element);
			}
		}

		public void Sum()
		{
			double Sum = stringList.Sum(x => Convert.ToDouble(x));
			Console.WriteLine($"Sum is : {Sum}");
		}
	}
}
