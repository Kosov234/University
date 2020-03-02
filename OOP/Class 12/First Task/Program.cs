using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._12._19
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> stringList = new List<string>();
			FillAList(stringList);
			RemoveMiddleElementAtList(stringList);
			RemoveLastElementAtList(stringList);
			ShowAList(stringList);
			
		}

		public static void FillAList(List<string> stringList)
		{
			string input = Console.ReadLine();
			while (input.ToLower() != "done")
			{
				stringList.Add(input);
				input = Console.ReadLine();
			}
		}

		public static void ShowAList(List<string> stringList) 
		{
			foreach (var element in stringList)
			{
				Console.WriteLine(element);
			}
		}

		public static void RemoveMiddleElementAtList(List<string> stringList)
		{
			stringList.RemoveAt((stringList.Count - 1)/2);
		}

		public static void RemoveLastElementAtList(List<string> stringList)
		{
			stringList.RemoveAt(stringList.Count - 1);
		}
	}
}
