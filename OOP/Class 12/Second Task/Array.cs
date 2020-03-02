using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
	class Array : IFillAndSum
	{
		private string[] stringArray = new string[5];

		public void Fill()
		{

			int currentPosition = 0;
			string input = Console.ReadLine();

			while (input.ToLower() != "done")
			{
				if (currentPosition == stringArray.Length)
					stringArray = ExtendArraySize(stringArray);

				stringArray[currentPosition++] = input;
				input = Console.ReadLine();
			}

		}

		public static string[] ExtendArraySize(string[] arrayToExtend)
		{
			string[] extendedArray = new string[arrayToExtend.Length * 2];

			for (int i = 0; i < arrayToExtend.Length; i++)
				extendedArray[i] = arrayToExtend[i];

			return extendedArray;
		}

		public void Show()
		{
			foreach (var element in stringArray)
			{
				Console.WriteLine(element);
			}
		}

		public void Sum()
		{
			double Sum = 0;
			foreach (var element in stringArray)
			{
				if(element != null)
					Sum += double.Parse(element);
			}
			Console.WriteLine($"The Sum is {Sum}");
		}
	}
}
